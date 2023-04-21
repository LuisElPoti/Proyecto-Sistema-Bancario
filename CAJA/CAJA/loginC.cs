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
    public partial class loginC : Form
    {

        public loginC()
        {
            InitializeComponent();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            using (DBCajaEntities db = new DBCajaEntities())
            {
                var conn = (SqlConnection)db.Database.Connection;
                conn.Open();
                string userName = txtBox_usuario.Text;
                string query = "SELECT id_cajero FROM cajeros WHERE nombre_cajero = @UserName";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserName", userName);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        CurrentUser.SetUser(Convert.ToInt32(result), txtBox_usuario.Text, txtBox_contrasena.Text);
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT nombre_cajero, clave_cajero FROM cajeros WHERE nombre_cajero=@nombre_cajero AND clave_cajero=@clave_cajero", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre_cajero", txtBox_usuario.Text);
                        cmd.Parameters.AddWithValue("@clave_cajero", txtBox_contrasena.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                menuC m1 = new menuC();
                                this.Hide();
                                m1.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No es usuario");
                            }
                        }
                    }
                    conn.Close();
                }
            }
        }
    }
}

