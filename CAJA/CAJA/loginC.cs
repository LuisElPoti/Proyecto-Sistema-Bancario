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
                string query = "SELECT id_cajero, id_caja, id_sucursal FROM cajeros WHERE nombre_cajero = @UserName";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserName", userName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            int id_caja = reader.GetInt32(1);
                            int id_sucursal = reader.GetInt32(2);
                            CurrentUser.SetUser(id, txtBox_usuario.Text, txtBox_contrasena.Text, id_caja, id_sucursal);
                        }
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

