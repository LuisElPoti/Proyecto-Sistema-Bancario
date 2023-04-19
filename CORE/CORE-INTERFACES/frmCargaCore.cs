using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CORE_INTERFACES
{
    public partial class frmCargaCore : Form
    {
        
        public frmCargaCore()
        {
            InitializeComponent();
        }
        int start = 0;
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 2;
            pbProgreso.Value = start;
            if(pbProgreso.Value == 100) 
            {
                pbProgreso.Value = 0;
                timer1.Stop();
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
                
            }
        }

        private void frmCargaCore_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
