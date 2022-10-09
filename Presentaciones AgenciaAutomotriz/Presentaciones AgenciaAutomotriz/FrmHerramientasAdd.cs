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
    public partial class FrmHerramientasAdd : Form
    {
        ManejadorHerramientas mp;
        public FrmHerramientasAdd()
        {
            InitializeComponent();
            mp = new ManejadorHerramientas();
            if (FrmProductos.p.IdProducto > 0)
            {
                txtCodigoHerramienta.Text = FrmProductos.p.CodigoBarras.ToString();
                txtNombre.Text = FrmProductos.p.Nombre;
                txtDescripcion.Text = FrmProductos.p.Descripcion.ToString();
                txtMarca.Text = FrmProductos.p.Marca.ToString();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Close();
            var valida = mp.ValidarHerramientas(txtCodigoHerramienta.Text, txtNombre.Text, txtMedida.Text, txtMarca.Text,txtDescripcion.Text);
            if (valida.Item1)
            {
                mp.Guardar(new Herramientas(FrmHerramientas.p.IdHerramientas, txtCodigoHerramienta.Text, txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text));
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK);
            }
            Close();
        }
    }
}
