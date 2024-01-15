using System;
using System.Data;
using System.Data.SqlClient;

namespace Misce.Datos
{
    public class DCategoria
    {
        public DataTable ListarCategorias(int estado)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Sqlcon = Conexion.GetInstancia().CrearConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_ListarCategorias", Sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@estado", SqlDbType.Int).Value = estado;
                        Sqlcon.Open();
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
                throw ex;
            }
        }
    }
}
