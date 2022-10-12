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
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramientas mp;
        public static Herramientas p = new Herramientas(0, "", "","", "", "");
        int fila = 0, col = 0;
        public FrmHerramientas()
        {
            InitializeComponent();
            mp = new ManejadorHerramientas();
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
            mp.Mostrar(dgvHerramientas, txtBuscar.Text);
        }
        private void dgvHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 6:
                    {
                        FrmHerramientasAdd pd = new FrmHerramientasAdd();
                        pd.ShowDialog();
                        txtBuscar.Text = "";
                        actualizar();
                    }
                    break;
                case 7:
                    {
                        mp.Borrar(p);
                        txtBuscar.Text = "";
                        actualizar();
                    }
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p.IdHerramientas = -1;
            FrmHerramientasAdd pd = new FrmHerramientasAdd();
            pd.ShowDialog();
        }

        private void dgvHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
            {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            p.IdHerramientas = int.Parse(dgvHerramientas.Rows[fila].Cells[0].Value.ToString());
            p.CodigoHerramientas = dgvHerramientas.Rows[fila].Cells[1].Value.ToString();
            p.Nombre = dgvHerramientas.Rows[fila].Cells[2].Value.ToString();
            p.Medida = dgvHerramientas.Rows[fila].Cells[3].Value.ToString();
            p.Marca = dgvHerramientas.Rows[fila].Cells[4].Value.ToString();
            p.Descripcion = dgvHerramientas.Rows[fila].Cells[5].Value.ToString();
        }
    }
}
