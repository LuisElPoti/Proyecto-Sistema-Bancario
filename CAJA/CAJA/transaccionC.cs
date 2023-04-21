using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CAJA
{
    public partial class transaccionC : Form
    {
        public transaccionC()
        {
            InitializeComponent();
            CB_tipo_transaccion.Items.Add("deposito");
            CB_tipo_transaccion.Items.Add("retiro");
            CB_tipo_transaccion.Items.Add("prestamo");

            CB_moneda_transaccion.Items.Add("DOM");
            CB_moneda_transaccion.Items.Add("USD");
            CB_moneda_transaccion.Items.Add("EUR");
        }

        private void txtBox_monto_transaccion_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtBox_numero_cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private int getTransaction_type(string cb)
        {

            switch (cb)
            {
                case "deposito":
                    return 1;
                case "retiro":
                    return 2;
                case "prestamo":
                    return 3;
                default:
                    return 0;
            }

        }

        private int getMoneda_type(string cb)
        {

            switch (cb)
            {
                case "DOM":
                    return 1;
                case "USD":
                    return 2;
                case "EUR":
                    return 3;
                default:
                    return 0;
            }

        }

        private bool sendTransaction()
        {
            wsReferenceCuenta.WSCuentaClient referencia = new wsReferenceCuenta.WSCuentaClient();
            var transactionGO = referencia.Deposito_Retiro(1, txtBox_numero_cuenta.Text, decimal.Parse(txtBox_monto_transaccion.Text));
            if (transactionGO == true)
            {
                referencia.Deposito_Retiro(1, txtBox_numero_cuenta.Text, decimal.Parse(txtBox_monto_transaccion.Text));
                return true;
            }
            else return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (DBCajaEntities db = new DBCajaEntities())
            {

                var conn = (SqlConnection)db.Database.Connection;

                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    if (sendTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand("sp_insertar_transaccion", conn, transaction))
                            {
                                command.CommandType = CommandType.StoredProcedure;

                                command.Parameters.AddWithValue("@id_cajero", CurrentUser.Id);
                                command.Parameters.AddWithValue("@num_cuenta_origen", txtBox_numero_cuenta);
                                command.Parameters.AddWithValue("@num_cuenta_destino", txtBox_numero_cuenta);
                                command.Parameters.AddWithValue("@id_tipo_transaccion", getTransaction_type(CB_tipo_transaccion.SelectedItem.ToString()));
                                command.Parameters.AddWithValue("@id_moneda", getMoneda_type(CB_moneda_transaccion.SelectedItem.ToString()));
                                command.Parameters.AddWithValue("@monto_transaccion", txtBox_monto_transaccion);
                                command.Parameters.AddWithValue("@id_estado_transaccion", 1);

                                int rowsAffected = command.ExecuteNonQuery();
                                MessageBox.Show("la transaccion fue un exito");

                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("la transaccion fue un error por rollback");
                        }

                    }else { MessageBox.Show("la transaccion fue un error"); }
                    conn.Close();
                }
            }
        }
    }
}
