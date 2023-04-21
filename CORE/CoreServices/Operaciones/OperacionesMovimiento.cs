using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoreServices.Operaciones
{
    public class OperacionesMovimiento
    {
        public List<Movimiento> GetAllMovimientobyCuenta()
        {
            using (DBCoreEntities1 db = new DBCoreEntities1())
            {
                var movimientos = new List<Movimiento>();
                try
                {
                    using (var cmd = db.Database.Connection.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Movimiento";
                        cmd.CommandType = CommandType.Text;
                        if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movimiento = new Movimiento();
                                movimiento.idMovimiento = (int)reader[0];
                                movimiento.idCuenta = (int)reader[1];
                                movimiento.Monto = (decimal)reader[2];
                                movimiento.Descripcion = reader[3].ToString();
                                movimiento.FechaIngreso = DateTime.Parse(reader[4].ToString());
                                movimientos.Add(movimiento);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los perfiles", ex);
                }
                return movimientos;
            }
        }

    }
}