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
        public cajaC()
        {
            InitializeComponent();
            cmbox_opciones.Items.Add("entrada");
            cmbox_opciones.Items.Add("salida");

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

        private int tipo_transaccionCore(string cb)
        {
            if (cb == "entrada")
            {
                return 1;
            }
            else if (cb == "salida")
            {
                return 2;
            }
            else return 3;
        }

        private void btn_realizar_Click(object sender, EventArgs e)
        {
            using (DBCajaEntities db = new DBCajaEntities())
            {

                var conn = (SqlConnection)db.Database.Connection;

                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand("sp_modificar_monto_caja", conn, transaction))
                        {
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@id_caja", CurrentUser.Id_caja);
                            command.Parameters.AddWithValue("@Tipo", tipo_transaccionCore(cmbox_opciones.SelectedItem.ToString()));
                            command.Parameters.AddWithValue("@Monto", (txtBox_montocaja.Text));

                            command.ExecuteNonQuery();

                            Console.WriteLine("Stored procedure executed successfully.");

                            transaction.Commit();
                        }
                    }catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("la transaccion fue un error por rollback");
                    }
                }
            }
        }


        private void txtBox_Cajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_montocaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbox_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
