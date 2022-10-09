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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mp;
        public static Usuarios p = new Usuarios(0, "", "", "", "","");
        int fila = 0, col = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mp = new ManejadorUsuarios();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            actualizar();
        }
        void actualizar()
        {
            mp.Mostrar(dgvUsuarios, textBox1.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p.IdUsuario = -1;
            btnGuardar pd = new btnGuardar();
            pd.ShowDialog();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 7:
                    {
                        btnGuardar pd = new btnGuardar();
                        pd.ShowDialog();
                        textBox1.Text = "";
                        actualizar();
                    }
                    break;
                case 8:
                    {
                        mp.Borrar(p);
                        textBox1.Text = "";
                        actualizar();
                    }
                    break;
            }
        }

        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            p.IdUsuario = int.Parse(dgvUsuarios.Rows[fila].Cells[0].Value.ToString());
            p.Nombre = dgvUsuarios.Rows[fila].Cells[1].Value.ToString();
            p.Apellidop = dgvUsuarios.Rows[fila].Cells[2].Value.ToString();
            p.Apellidom = dgvUsuarios.Rows[fila].Cells[3].Value.ToString();
            p.Fdn = dgvUsuarios.Rows[fila].Cells[4].Value.ToString();
            p.Rfc = dgvUsuarios.Rows[fila].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
