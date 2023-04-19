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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.btnUsuario.BackColor = Color.Navy;
        }

        private void btnUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.btnUsuario.BackColor = ColorTranslator.FromHtml("#200752");
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmUsuario());
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmPerfil());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmClientes());
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmCuentas());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmPrestamos());
        }

        private void btnTransacción_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmTipoTransacción());
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
