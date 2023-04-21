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
    }
}
