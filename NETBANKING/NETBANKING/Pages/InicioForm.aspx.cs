﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETBANKING.Pages
{
    public partial class InicioForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerMas_Click(object sender, EventArgs e)
        {
            Response.Redirect("\\Pages\\DetalleCuentaForm.aspx");

        }
    }
}