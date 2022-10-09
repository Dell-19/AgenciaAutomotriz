using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using AccesoDatos_AgenciaAutomotriz;
using System.Drawing;
using Entidades_AgenciaAutomotriz;
using System.Windows.Forms;

namespace Manejadores_AgenciaAutomotriz
{
    public class ManejadorUsuarios:IManejador
    {
        AccesoUsuarios ap = new AccesoUsuarios();
        Grafico g = new Grafico();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas Seguro de Borrar?  : {0}", Entidad.Nombre), "Atencion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }


        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Usuario Guardado", "!ATENCION!!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["usuarios"];
            tabla.Columns.Insert(6, g.Boton("Editar", Color.Aqua));
            tabla.Columns.Insert(7, g.Boton("Borrar", Color.BlueViolet));
            tabla.Columns[0].Visible = false;
        }

        public Tuple<bool, string> ValidarUsuario(string uno, string dos, string tres, string cuatro,string cinco)
        {
            bool error = true;
            string cadenaErrores = "";
            if (uno.Length == 0 || uno == null)
            {
                cadenaErrores = cadenaErrores + "-El campo no puede ser vacio\n";
                error = false;
            }
            if (dos.Length == 0 || dos == null)
            {
                cadenaErrores = cadenaErrores + "-El campo  no puede ser vacio\n";
                error = false;
            }
            if (tres.Length == 0 || tres == null)
            {
                cadenaErrores = cadenaErrores + "-El campo no puede ser vacio\n";
                error = false;
            }
            if (cuatro.Length == 0 || cuatro == null)
            {
                cadenaErrores = cadenaErrores + "-El campo no puede ser vacio\n";
                error = false;
            }
            if (cinco.Length == 0 || cinco == null)
            {
                cadenaErrores = cadenaErrores + "-El campo no puede ser vacio\n";
                error = false;
            }
            var valida = new Tuple<bool, string>(error, cadenaErrores);
            return valida;
        }
    }
}
