using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_AgenciaAutomotriz
{
    public class Herramientas
    {
        public Herramientas(int idHerramientas, string codigoHerramientas, string nombre,
            string medida, string marca, string descripcion)
        {
            IdHerramientas = idHerramientas;
            CodigoHerramientas = codigoHerramientas;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descripcion = descripcion;
        }
        public int IdHerramientas { get; set; }
        public string CodigoHerramientas { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
    }
}
