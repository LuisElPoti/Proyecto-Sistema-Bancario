using NETBANKING.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=sistema-bancario-server.database.windows.net;Initial Catalog=DBNetBanking;Persist Security Info=True;User ID=Administrador;Password=***********;MultipleActiveResultSets=True;Application Name=EntityFramework";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            string sql = "SELECT dbo.fnValidarUsuario(@Usuario, @Usuario)";
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Clave", txtClave.Text);
            int resultado = (int)cmd.ExecuteScalar();

            if (resultado == 1)
            {
                Response.Redirect("InicioForm.aspx");
            }
            else
            {
                Response.Redirect("InicioForm.aspx");


            }


        }

    }
}