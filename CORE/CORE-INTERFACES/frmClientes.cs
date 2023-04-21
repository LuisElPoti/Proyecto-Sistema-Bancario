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
            Referencia.CrearCliente(tbNombre.Text, int.Parse(cbTipoDocumento.Text), tbDocumento.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, DateTime.Parse(tpFechaNacimiento.Text));
            MessageBox.Show("Usuario Registrado!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Referencia.ActualizarCliente(int.Parse(tbID.Text), tbNombre.Text, int.Parse(cbTipoDocumento.Text), tbDocumento.Text, tbCorreo.Text, tbTelefono.Text, tbDireccion.Text, DateTime.Parse(tpFechaNacimiento.Text));
            MessageBox.Show("Cliente Modificado!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Referencia.EliminarCliente(int.Parse(tbID.Text));
            MessageBox.Show("Usuario Eliminado!");
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (Referencia.BuscarCliente(int.Parse(tbID.Text)) != null)
            {
                dt = Referencia.BuscarCliente(int.Parse(tbID.Text));
                MessageBox.Show("Cliente encontrado.");
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
            
        }
    }
}
