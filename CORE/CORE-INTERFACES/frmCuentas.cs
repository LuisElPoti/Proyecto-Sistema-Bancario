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

        private int TipoCuentaInt (string TipoCuenta)
        {
            if (TipoCuenta.ToLower() == "ahorro")
                return 1;

            return 3;
                    
        }

        private int BancoInt (string Banco)
        {
            if (Banco.ToLower() == "banreservas")
                return 1;
            if(Banco.ToLower() == "bhd")
                return 2;
            if(Banco.ToLower() == "popular")
                return 3;
            return 4;
        }

        private bool Estadobool (string Estado)
        {
            if (Estado.ToLower() == "activo")
                return true;
            return false;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Referencia.CrearCuenta(int.Parse(tbCliente.Text), TipoCuentaInt(cbTipoCuenta.Text), BancoInt(cbBanco.Text), tbNoCuenta.Text, Estadobool(cbEstado.Text));
            MessageBox.Show("Cuenta Registrada. ");
            tbCliente.Text = cbTipoCuenta.Text = cbBanco.Text = cbEstado.Text = tbNoCuenta.Text = cbEstado.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Referencia.ActualizarCuenta(int.Parse(tbID.Text), Estadobool(cbEstado.Text), decimal.Parse(tbBalance.Text));
            MessageBox.Show("Cuenta Actualizada. ");
            tbCliente.Text = cbTipoCuenta.Text = cbBanco.Text = cbEstado.Text = tbNoCuenta.Text = cbEstado.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Referencia.EliminarCuenta(int.Parse(tbID.Text));
            MessageBox.Show("Cuenta Eliminada.");
            tbCliente.Text = cbTipoCuenta.Text = cbBanco.Text = cbEstado.Text = tbNoCuenta.Text = cbEstado.Text = "";
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
