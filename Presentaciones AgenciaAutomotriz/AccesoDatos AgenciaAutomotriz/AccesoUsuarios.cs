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
    public class AccesoUsuarios : IAccesos
    {
        Base b = new Base("localhost", "root", "", "agenciaAutomotriz");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteusuario({0})", Entidad.IdUsuario));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarusuario('{0}','{1}','{2}','{3}','{4}',{5})",
            Entidad.Nombre, Entidad.Apellidop, Entidad.Apellidom, Entidad.Fdn,Entidad.Rfc, Entidad.IdUsuario));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                 (string.Format("call showusuario('%{0}%')", filtro), "usuarios");
        }
    }
}
