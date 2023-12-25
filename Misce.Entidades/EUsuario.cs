using System;

namespace Misce.Entidades
{
    public class EUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdTipoUsuario { get; set; }
        public string Foto { get; set; }
        public string Estado { get; set; }
    }
}
