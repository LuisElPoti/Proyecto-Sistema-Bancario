using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Servicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes.WSClientesClient Referencia = new Clientes.WSClientesClient();

            Referencia.AgregarCliente("Joaquin", 1, "402566", "Joaquin@gmail.com", "8299628881", "Avenida", DateTime.Now);

            MessageBox.Show("Servicio Usado");
        }
    }
}
