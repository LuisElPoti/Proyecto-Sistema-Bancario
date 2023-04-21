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

namespace CAJA
{
    public partial class cajaC : Form
    {
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

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                decimal Monto = Convert.ToDecimal(txtBox_montocaja.Text);

                SqlCommand cmd = new SqlCommand("INSERT INTO caja (monto_caja, id_sucursal) VALUES (@Monto, 2)", conn);
                cmd.Parameters.AddWithValue("@Monto", Monto);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Transacción realizada de manera exitosa");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un valor decimal válido");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo completar la transacción");
            }

            conn.Close();
        }
    }
}
