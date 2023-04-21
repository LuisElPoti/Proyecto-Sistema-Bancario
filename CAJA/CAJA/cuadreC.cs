using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
