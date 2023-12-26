using Misce.Datos;
using System.Data;

namespace Misce.Negocio
{
    public class NUsuario
    {
        public static DataTable Acceder(string usuario, string clave)
        {
            DUsuario datos = new DUsuario();
            return datos.Acceder(usuario, clave);
        }
    }
}
