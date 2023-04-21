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
    public partial class contadorC : Form
    {

        private readonly Action<int> _updateResultCallback;
        public contadorC(Action<int> updateResultCallback)
        {
            InitializeComponent();
            _updateResultCallback = updateResultCallback;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_suma_contador_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int num1);
            int.TryParse(textBox2.Text, out int num2);
            int.TryParse(textBox3.Text, out int num3);
            int.TryParse(textBox4.Text, out int num4);
            int.TryParse(textBox5.Text, out int num5);
            int.TryParse(textBox6.Text, out int num6);
            int.TryParse(textBox7.Text, out int num7);
            int.TryParse(textBox8.Text, out int num8);
            int.TryParse(textBox9.Text, out int num9);
            int.TryParse(textBox10.Text, out int num10);

            int suma = (num1 * 2000) + (num2 * 1000) +
                (num3 * 500) + (num4 * 200) + (num5 * 100) +
                (num6 * 50) + (num7 * 25) + (num8 * 10) + (num9 * 5) +
                (num10);


            _updateResultCallback(suma);

            this.Close();
        }
    }
}
