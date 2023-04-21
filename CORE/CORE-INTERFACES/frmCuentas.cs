using CoreServices;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Referencia.ActualizarCuenta(int.Parse(tbID.Text),bool.Parse(cbEstado.Text),decimal.Parse(tbBalance.Text));
            MessageBox.Show("Cuenta Actualizada. ");
            cbCliente.Text = cbTipoCuenta.Text = cbBanco.Text = cbEstado.Text = tbNoCuenta.Text = cbEstado.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Referencia.EliminarCuenta(int.Parse(tbID.Text));
            MessageBox.Show("Cuenta Eliminada.");
            cbCliente.Text = cbTipoCuenta.Text = cbBanco.Text = cbEstado.Text = tbNoCuenta.Text = cbEstado.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                wsReferenceCuenta.WSCuentaClient Cuenta = new wsReferenceCuenta.WSCuentaClient();
                List<Cuenta> Cuentas = new List<Cuenta>();
                Cuentas = Cuenta.BuscarCuenta(id);
                //List<Cliente> clientes = client.BuscarCliente(id);

                if (Cuentas != null && Cuentas.Count > 0)
                {
                    dgvCuenta.DataSource = Cuentas;
                    MessageBox.Show("Cliente encontrado.");
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }
    }
}
