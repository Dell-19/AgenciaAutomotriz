using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores_AgenciaAutomotriz;
using Entidades_AgenciaAutomotriz;

namespace Presentaciones_AgenciaAutomotriz
{
    public partial class FrmProductosAdd : Form
    {
        ManejadorProductos mp;
        public FrmProductosAdd()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if (FrmProductos.p.IdProducto > 0)
            {
                txtCodigoBarras.Text = FrmProductos.p.CodigoBarras.ToString();
                txtNombre.Text = FrmProductos.p.Nombre;
                txtDescripcion.Text = FrmProductos.p.Descripcion.ToString();
                txtMarca.Text = FrmProductos.p.Marca.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Close();
            var valida = mp.ValidarProductos(txtCodigoBarras.Text, txtNombre.Text, txtDescripcion.Text,txtMarca.Text);
            if (valida.Item1)
            {
                mp.Guardar(new Productos(FrmProductos.p.IdProducto, txtCodigoBarras.Text, txtNombre.Text,
                 txtDescripcion.Text,txtMarca.Text));
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK);
            }
            Close();
        }
    }
}
