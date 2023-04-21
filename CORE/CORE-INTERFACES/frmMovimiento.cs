using CoreServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_INTERFACES
{
    public partial class frmMovimiento : Form
    {
        
        wsReferenceMovimiento.WSMovimientoClient Referencia = new wsReferenceMovimiento.WSMovimientoClient();
        public frmMovimiento()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMovimiento_Load(object sender, EventArgs e)
        {
            CargarMovimiento();
        }
        public void CargarMovimiento()
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            movimientos = Referencia.MostrarMovimientoCuenta();
            dgvMovimientos.DataSource = movimientos;
            dgvMovimientos.AutoGenerateColumns = true;
        }
    }
}
