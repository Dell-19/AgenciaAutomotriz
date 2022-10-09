using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud;
using AccesoDatos_AgenciaAutomotriz;
using System.Drawing;

namespace Manejadores_AgenciaAutomotriz
{
    public class ManejadorProductos : IManejador
    {
        AccesoProductos ap = new AccesoProductos();
        Grafico g = new Grafico();

        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas Seguro de Borrar?  : {0}", Entidad.CodigoBarras), "Atencion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }


        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Producto Guardado", "!ATENCION!!", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.Mostrar(filtro).Tables["pais"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.Aqua));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Lime));
            tabla.Columns[0].Visible = false;
        }
    }
}
