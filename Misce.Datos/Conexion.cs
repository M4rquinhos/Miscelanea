using System;
using System.Data.SqlClient;

namespace Misce.Datos
{
    public class Conexion
    {
        private string bd;
        private string servidor;
        private string usuario;
        private string clave;
        private bool seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.bd = "MISCELANEA";
            this.servidor = "DESKTOP-TBL2D3P\\SQLEXPRESS";
            this.usuario = "sistemas";
            this.clave = "1234";
            this.seguridad = false;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = $"Server={this.servidor}; Database={this.bd};";
                if (this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + $"Integrated Security = SSPI;";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + $"User Id={this.usuario}; Password={this.clave};";
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion GetInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
