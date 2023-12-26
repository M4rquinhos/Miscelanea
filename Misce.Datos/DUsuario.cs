using Misce.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Misce.Datos
{
    public class DUsuario
    {
        public EUsuario usuario = new EUsuario();

        public DataTable Acceder(string usuario, string clave)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection sqlCon = Conexion.GetInstancia().CrearConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_LogIn", sqlCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                        cmd.Parameters.Add("@clave", SqlDbType.VarChar).Value = clave;
                        //cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
                        sqlCon.Open();
                        using (SqlDataReader resultado = cmd.ExecuteReader())
                        {
                            tabla.Load(resultado);
                        }
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
