﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Cliente.WSClienteClient cliente = new Cliente.WSClienteClient();

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.EliminarCliente(1);
        }
    }
}
