using NETBANKING.LoginPages;
using NETBANKING.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NETBANKING
{
   
    public partial class LoginForm : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignInForm.aspx");
        }

        protected void btnAceptar_Click1(object sender, EventArgs e)
        {
            using (DBNetBankingEntities1 db = new DBNetBankingEntities1())
            {
               
                var conn = db.Database.Connection;
                var connectionState = conn.State;

                if (connectionState != ConnectionState.Open)
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "ValidarUsuario";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("nombre", txtUsuario.Text));
                        cmd.Parameters.Add(new SqlParameter("clave", txtClave.Text));
                        using (var reader = cmd.ExecuteReader())
                        {
                     
                        if (reader.Read())
                            {
                                
                                Response.Redirect("InicioForm.aspx");
                            }
                            else
                            {
                                txtUsuario.Text = " ";
                                txtClave.Text = " ";
                            }
                        }
                    }
                

              
            }

        }
    }
}