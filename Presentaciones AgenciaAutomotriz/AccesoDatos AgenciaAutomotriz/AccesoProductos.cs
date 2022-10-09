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
    public class AccesoProductos : IAccesos
    {
        Base b = new Base("localhost", "root", "", "agenciaAutomotriz");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteproducto({0})", Entidad.IdProducto));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarproducto({0},'{1}',{2},{3},{4})",
            Entidad.CodigoBarra, Entidad.Nombre, Entidad.Descripcion,Entidad.Marca,Entidad.IdProducto));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("call showproducto('%{0}%')", filtro), "productos");
        }
    }
}
