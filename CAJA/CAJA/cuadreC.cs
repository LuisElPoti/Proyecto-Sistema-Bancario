using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAJA
{
    public partial class cuadreC : Form
    {
        public cuadreC()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            contadorC contadorc = new contadorC((result) => txtBox_monto_inicio.Text = result.ToString());
            contadorc.ShowDialog();

            btn_monto_inicio.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuC m1 = new menuC();
            this.Hide();
            m1.ShowDialog();
            this.Close();
        }

        private void btn_hora_inicio_Click(object sender, EventArgs e)
        {

            DateTime currentTime = DateTime.Now;
            txtBox_hora_inicio.Text = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            btn_hora_inicio.Enabled = false;
        }

        private void btn_monto_final_Click(object sender, EventArgs e)
        {
            contadorC contadorc = new contadorC((result) => txtBox_monto_final.Text = result.ToString());
            contadorc.ShowDialog();

            btn_monto_inicio.Enabled = false;
        }

        private void btx_realizar_cuadre_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox[] textBoxes = { txtBox_hora_inicio, txtBox_monto_final, txtBox_monto_inicio };

            foreach (System.Windows.Forms.TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("LLene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    using (DBCajaEntities db = new DBCajaEntities())
                    {
                        var conn = (SqlConnection)db.Database.Connection;
                        conn.Open();

                        string sqlQuery = "SELECT monto_caja FROM caja WHERE id_caja = @idCaja";
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                        {
                            command.Parameters.AddWithValue("@idCaja", CurrentUser.Id_caja);

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    txtBox_monto_caja.Text = reader.GetDecimal(0).ToString();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron registros.");
                            }

                            reader.Close();
                        }

                        conn.Close();
                    }

                    txt_diferencia_caja.Text = (decimal.Parse(txtBox_monto_caja.Text) - decimal.Parse(txtBox_monto_final.Text)).ToString();
                }
            }

        }
    }
}

