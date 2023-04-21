using CORE_INTERFACES.wsReferenceCliente;
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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        wsReferenceCliente.WSClienteClient Referencia = new wsReferenceCliente.WSClienteClient();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Referencia.CrearCliente(tbNombre.Text, AsignarTipoDocumento(cbTipoDocumento.Text), tbDocumento.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, DateTime.Parse(tpFechaNacimiento.Text));
            MessageBox.Show("Usuario Registrado!");
            tbID.Text = tbNombre.Text = cbTipoDocumento.Text = tbDocumento.Text = tbCorreo.Text = tbTelefono.Text = tbDireccion.Text = tpFechaNacimiento.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Referencia.ActualizarCliente(int.Parse(tbID.Text), tbNombre.Text, AsignarTipoDocumento(cbTipoDocumento.Text), tbDocumento.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, DateTime.Parse(tpFechaNacimiento.Text));
            MessageBox.Show("Cliente Modificado!");
            tbID.Text = tbNombre.Text = cbTipoDocumento.Text = tbDocumento.Text = tbCorreo.Text = tbTelefono.Text = tbDireccion.Text = tpFechaNacimiento.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Referencia.EliminarCliente(int.Parse(tbID.Text));
            MessageBox.Show("Usuario Eliminado!");
            tbID.Text = tbNombre.Text = cbTipoDocumento.Text = tbDocumento.Text = tbCorreo.Text = tbTelefono.Text = tbDireccion.Text = tpFechaNacimiento.Text = "";
        }

        private int AsignarTipoDocumento(string tipoDocumento)
        {
            if (tipoDocumento.ToLower() == "cédula")
                return 1;

            return 2;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                wsReferenceCliente.WSClienteClient client = new wsReferenceCliente.WSClienteClient();
                List<Cliente> clientes = new List<Cliente>();
                clientes = client.BuscarCliente(id);
                //List<Cliente> clientes = client.BuscarCliente(id);

                if (clientes != null && clientes.Count > 0)
                {
                    dgbClientes.DataSource = clientes;
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
            //DataTable dt =  Referencia.BuscarCliente(int.Parse(tbID.Text));
            //dgbClientes.DataSource = dt;
            //dgbClientes.Refresh();
            //dt = Referencia.BuscarCliente(int.Parse(tbID.Text));
            //MessageBox.Show("Cliente encontrado.");
            //tbNombre.Text = dt.Rows[1].ToString();
            //cbTipoDocumento.Text = dt.Rows[2].ToString();
            //tbDocumento.Text = dt.Rows[3].ToString();
            //tbCorreo.Text = dt.Rows[4].ToString();
            //tbTelefono.Text = dt.Rows[5].ToString();
            //tbDireccion.Text = dt.Rows[6].ToString();
            //tpFechaNacimiento.Text = dt.Rows[7].ToString();
        }
    }
}
