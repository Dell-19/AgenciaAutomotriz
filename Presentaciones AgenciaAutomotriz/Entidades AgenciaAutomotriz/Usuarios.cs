using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_AgenciaAutomotriz
{
    public class Usuarios
    {
        public Usuarios(int idUsuario, string nombre, string apellidop, string apellidom, string fdn, string rfc)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellidop = apellidop;
            Apellidom = apellidom;
            Fdn = fdn;
            Rfc = rfc;
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string Fdn { get; set; }
        public string Rfc { get; set; }
    }
}
