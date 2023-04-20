using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesPerfil
    {

        public spGetAllPerfil_Result[] GetPerfil()
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                return db.spGetAllPerfil().ToArray();
            }
        }


        /*
         * public List<CollegeDetail> GetCollegeRecords()  
        {  
            using (CollegeDataEntities context = new CollegeDataEntities())  
            {  
                return context.CollegeDetails.ToList();  
            }  
        }
        */

        public bool InsertPerfil(string nombre, string descripcion)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertPerfil(nombre, descripcion);

                if (Convert.ToInt32(ReturnedValue.Value) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UpdatePerfiles(int idPerfil, string nombre, string descripcion)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertPerfil(idPerfil, nombre, descripcion);

                if (ReturnedValue >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeletePerfil(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spDeletePerfil(id);

                if (ReturnedValue >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Perfil GetPerfilbyID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                Perfil Perfiles = null;

                try
                {
                    Perfil Correspondiente = db.Perfil.First((p) => p.idPerfil == id);

                    Perfiles.idPerfil = Correspondiente.idPerfil;
                    Perfiles.Nombre = Correspondiente.Nombre;
                    Perfiles.Descripcion = Correspondiente.Descripcion;

                    return Perfiles;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}