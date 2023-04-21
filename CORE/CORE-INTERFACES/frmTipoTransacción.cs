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
    public partial class frmTipoTransacción : Form
    {
        public frmTipoTransacción()
        {
            InitializeComponent();
        }

        wsReferencePerfil.WSPerfilClient Referencia = new wsReferencePerfil.WSPerfilClient();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Referencia.CrearPerfil(tbNombre.Text, tbDescripcion.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Referencia.ActualizarPerfil(int.Parse(tbID.Text), tbNombre.Text, tbDescripcion.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Referencia.EliminarPerfil(int.Parse(tbID.Text));
        }
    }
}
