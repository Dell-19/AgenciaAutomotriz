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
    public partial class btnGuardar : Form
    {
        ManejadorUsuarios  mp;
        public btnGuardar()
        {
            InitializeComponent();
            mp = new ManejadorUsuarios();
            if (FrmUsuarios.p.IdUsuario > 0)
            {
                txtNombre.Text = FrmUsuarios.p.Nombre.ToString();
                txtApellidop.Text = FrmUsuarios.p.Apellidop.ToString();
                txtApellidom.Text = FrmUsuarios.p.Apellidom.ToString();
                txtFdn.Text = FrmUsuarios.p.Fdn.ToString();
                txtRfc.Text = FrmUsuarios.p.Rfc.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            var valida = mp.ValidarUsuario(txtNombre.Text, txtApellidop.Text, txtApellidom.Text, txtFdn.Text,txtRfc.Text);
            if (valida.Item1)
            {
                mp.Guardar(new Usuarios(FrmUsuarios.p.IdUsuario, txtNombre.Text, txtApellidop.Text, txtApellidom.Text, txtFdn.Text, txtRfc.Text));
            }
            else
            {
                MessageBox.Show(valida.Item2, "Ocurrio un error", MessageBoxButtons.OK);
            }
            Close();
        }
    }
    }
