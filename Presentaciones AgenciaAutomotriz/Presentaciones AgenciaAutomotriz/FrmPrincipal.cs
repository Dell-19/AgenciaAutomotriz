using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentaciones_AgenciaAutomotriz
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmUsuarios u = new FrmUsuarios();
            u.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmHerramientas h = new FrmHerramientas();
            h.ShowDialog();
        }
        private void ControlarBotones(bool Usuarios, bool Productos, bool Herramientas)
        {
            toolStripButton1.Enabled = Usuarios;
            toolStripButton2.Enabled = Productos;
            toolStripButton3.Enabled = Herramientas;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmProductos p = new FrmProductos();
            p.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                ControlarBotones(true, true, true);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                ControlarBotones(false,false , true);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                ControlarBotones(false,true,false);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (true)
            {
                ControlarBotones(true,false, false);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (true)
            { ControlarBotones(false, false, false); }
        }
    }
}
