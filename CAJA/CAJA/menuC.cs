using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAJA
{
    public partial class menuC : Form
    {
        public menuC()
        {
            InitializeComponent();
        }

        private void btn_cuadre_Click(object sender, EventArgs e)
        {
            cuadreC c1 = new cuadreC();
            this.Hide();
            c1.ShowDialog();
            this.Close();

        }

        private void btn_transaccion_Click(object sender, EventArgs e)
        {
            transaccionC t1 = new transaccionC();
            this.Hide();
            t1.ShowDialog();
            this.Close();
        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            cajaC cajaC = new cajaC();
            this.Hide();
            cajaC.ShowDialog();
            this.Close();
        }
    }
}
