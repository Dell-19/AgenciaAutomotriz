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
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
        public static Productos p = new Productos(0,"", "","","");
        int fila = 0, col = 0;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        actualizar();
        }

    void actualizar()
    {
        mp.Mostrar(dgvProductos, txtBuscar.Text);
    }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 5:
                    {
                        FrmProductosAdd pd = new FrmProductosAdd();
                        pd.ShowDialog();
                        txtBuscar.Text = "";
                        actualizar();
                    }
                    break;
                case 6:
                    {
                        mp.Borrar(p);
                        txtBuscar.Text = "";
                        actualizar();
                    }
                    break;
            }
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            p.IdProducto = int.Parse(dgvProductos.Rows[fila].Cells[0].Value.ToString());
            p.CodigoBarras = dgvProductos.Rows[fila].Cells[1].Value.ToString();
            p.Nombre = dgvProductos.Rows[fila].Cells[2].Value.ToString();
            p.Descripcion = dgvProductos.Rows[fila].Cells[3].Value.ToString();
            p.Marca = dgvProductos.Rows[fila].Cells[4].Value.ToString();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p.IdProducto = -1;
            FrmProductosAdd pd = new FrmProductosAdd();
            pd.ShowDialog();
        }

    }
}
