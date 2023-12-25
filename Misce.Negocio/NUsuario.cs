using Misce.Datos;
using System.Data;

namespace Misce.Negocio
{
    public class NUsuario
    {
        public static DataTable Acceder(string usuario, string clave, string estado)
        {
            DUsuario datos = new DUsuario();
            return datos.Acceder(usuario, clave, estado);
        }
    }
}
