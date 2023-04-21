using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAJA
{
    public partial class cajaC : Form
    {
        decimal monto_total = 0;
        SqlConnection conn = new SqlConnection("Server=tcp:sistema-bancario-server.database.windows.net,1433;Database=DBCaja;User ID=Administrador@sistema-bancario-server;Password=sistema.banco21;Trusted_Connection=False;Encrypt=True;");

        public cajaC()
        {
            InitializeComponent();
        }

        private void txt_usuario_login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuC m1 = new menuC();
            this.Hide();
            m1.ShowDialog();
            this.Close();
        }

        //How to use References:
        wsReferenceCuenta.WSCuentaClient Reference = wsReferenceCuenta.WSCuentaClient();

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO caja (monto_caja, id_sucursal) VALUES (@Monto, 2)", conn);
                cmd.Parameters.AddWithValue("@Monto", monto_total);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Transacción realizada de manera exitosa");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo completar la transacción");
            }

            conn.Close();
        }

        private void cmbox_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_opciones.SelectedItem.ToString() == "Salida")
            {
                try
                {
                    decimal Monto = Convert.ToDecimal(txtBox_montocaja.Text);
                    monto_total -= Monto;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor ingrese un valor decimal válido");
                }
            }
            else if (cmbox_opciones.SelectedItem.ToString() == "Entrada")
            {
                try
                {
                    decimal Monto = Convert.ToDecimal(txtBox_montocaja.Text);
                    monto_total += Monto;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor ingrese un valor decimal válido");
                }
            }
        }
    }
}
