﻿using System;
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_MouseEnter(object sender, EventArgs e)
        {
            this.btnUsuario.BackColor = Color.Navy;
        }

        private void btnUsuario_MouseLeave(object sender, EventArgs e)
        {
            this.btnUsuario.BackColor = ColorTranslator.FromHtml("#200752");
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
