using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_INTERFACES
{
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        wsReferenceCuenta.WSCuentaClient Referencia = new wsReferenceCuenta.WSCuentaClient();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Referencia.CrearCuenta(int.Parse(cbCliente.Text), int.Parse(cbTipoCuenta.Text), int.Parse(cbBanco.Text), tbNoCuenta.Text, bool.Parse(cbEstado.Text));
            MessageBox.Show("Cuenta Registrada. ");
            cbCliente.Text = cbTipoCuenta.Text = cbBanco.Text = cbEstado.Text = tbNoCuenta.Text = cbEstado.Text = "";
        }


    }
}
