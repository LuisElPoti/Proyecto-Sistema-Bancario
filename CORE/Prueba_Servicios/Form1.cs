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
            Clientes.WSClientesClient Cliente = new Clientes.WSClientesClient();

            Cliente.AgregarCliente("Miguel",1,"402566","Miguel@gmail.com","8296697544","Avenida",DateTime.Now);

            MessageBox.Show("Servicio Usado");
        }
    }
}
