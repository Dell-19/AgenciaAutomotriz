using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades_AgenciaAutomotriz;

namespace AccesoDatos_AgenciaAutomotriz
{
    public class AcessoHerramientas
    {
        Base b = new Base("localhost", "root", "", "agenciaAutomotriz");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteherramientas({0})", Entidad.IdHerramientas));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarherramientas('{0}','{1}','{2}','{3}','{4}',{5})",
            Entidad.CodigoHerramientas, Entidad.Nombre, Entidad.Medida, Entidad.Marca,Entidad.Descripcion, Entidad.IdHerramientas));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("call showherramientas('%{0}%')", filtro), "herramientas");
        }
    }
}
