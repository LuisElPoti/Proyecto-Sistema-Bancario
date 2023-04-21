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
    public partial class login : Form
    {

        SqlConnection conn = new SqlConnection("Server=tcp:sistema-bancario-server.database.windows.net,1433;Database=DBCaja;User ID=Administrador@sistema-bancario-server;Password=sistema.banco21;Trusted_Connection=False;Encrypt=True;");


        public login()
        {
            InitializeComponent();
            
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT nombre_cajero, clave_cajero FROM cajeros WHERE nombre_cajero=@nombre_cajero AND clave_cajero=@clave_cajero", conn);
            cmd.Parameters.AddWithValue("@nombre_cajero", txtBox_usuario.Text);
            cmd.Parameters.AddWithValue("@clave_cajero", txtBox_contrasena.Text);

            SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    menu m1 = new menu();
                    this.Hide();
                    m1.ShowDialog();
                    this.Close();


            } else
            {
                MessageBox.Show("No es usuario");
            }

            conn.Close();

        }
    }
}
