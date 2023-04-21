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
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        wsReferencePerfil.WSPerfilClient Reference = new wsReferencePerfil.WSPerfilClient();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Reference.CrearPerfil(tbNombre.Text,tbDescripcion.Text);
            MessageBox.Show("Perfil Creado.");
            tbID.Text = tbNombre.Text = tbDescripcion.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                wsReferencePerfil.WSPerfilClient Reference = new wsReferencePerfil.WSPerfilClient();
                List<Perfil> perfiles = new List<Perfil>(); ;
                perfiles = Reference.BuscarPerfil(id);
                //List<Cliente> clientes = client.BuscarCliente(id);

                if (perfiles != null && perfiles.Count > 0)
                {
                    dgvPerfil.DataSource = perfiles;
                    MessageBox.Show("Perfil encontrado.");
                }
                else
                {
                    MessageBox.Show("Perfil no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Perfil: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Reference.ActualizarPerfil(int.Parse(tbID.Text), tbNombre.Text, tbDescripcion.Text);
            MessageBox.Show("Perfil Actualizado.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Reference.EliminarPerfil(int.Parse(tbID.Text));
        }
    }
}
