using NETBANKING.LoginPages;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace NETBANKING.Pages
{
    public partial class BeneficiariosForm : System.Web.UI.Page
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private int AsignarTipoDocumento(string tipoDocumento)
        {
            if (tipoDocumento.ToLower() == "Cédula")
                return 1;

            return 2;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            using (DBNetBankingEntities1 db = new DBNetBankingEntities1())
            {
                db.Database.BeginTransaction();
                try
                {
                    var banco = DdBanco.Text;
                    string query = "SELECT UsuarioID FROM tblUsuario WHERE UsuariID = 3";
                    string query2 = "SELECT BancoID FROM tblBanco WHERE Descripcion = @banco";
                    ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                    db.spInsertarBeneficiario(int.Parse(query), AsignarTipoDocumento(DdTipoDocumento.Text), txtDocumento.Text, txtAlias.Text, txtCorreo.Text, int.Parse(query2));

                    db.Database.CurrentTransaction.Commit();
                    log.Info("Se inserto correctamente el beneficiario: ");
                    
                }
                catch
                {
                    db.Database.CurrentTransaction.Rollback();
                    log.Info("No se inserto");
                }

            }


        }
    }
}