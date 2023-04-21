using CORE_INTERFACES.wsReferencePrestamo;
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
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        wsReferencePrestamo.IWSPrestamo Referencia = new wsReferencePrestamo.WSPrestamoClient();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Referencia.CrearPrestamo(int.Parse(tbIdCuenta.Text), decimal.Parse(tbMontoOriginal.Text), decimal.Parse(tbMondoPagar.Text), decimal.Parse(tbMontoOriginal.Text), DateTime.Parse(dtpFechaCorte.Text));
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Referencia.ActualizarPrestamo(int.Parse(tbID.Text), int.Parse(tbIdCuenta.Text),decimal.Parse(tbTasa.Text),decimal.Parse(tbMontoOriginal.Text),decimal.Parse(tbMontoOriginal.Text) - decimal.Parse(tbMondoPagar.Text),DateTime.Parse(dtpFechaCorte.Text));

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Referencia.EliminarPrestamo(int.Parse(tbID.Text));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                wsReferencePrestamo.WSPrestamoClient Referencia = new wsReferencePrestamo.WSPrestamoClient();
                List<Prestamo> Prestamos = new List<Prestamo>();
                Prestamos = Referencia.MostrarPrestamos(id);
                //List<Cliente> clientes = client.BuscarCliente(id);

                if (Prestamos != null && Prestamos.Count > 0)
                {
                    dgvPrestamo.DataSource = Prestamos;
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
            Referencia.MostrarPrestamos(int.Parse(tbID.Text));
        }
    }
}
