using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETBANKING.LoginPages
{
    public partial class SignInFormPt2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignInForm.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            using (DBNetBankingEntities1 db = new DBNetBankingEntities1())
            {

                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertarUsuario(TextNombreUsuario.Text, idTipoCuenta, idBanco, NumeroCuenta, Estado);
            }
        }
    }
}