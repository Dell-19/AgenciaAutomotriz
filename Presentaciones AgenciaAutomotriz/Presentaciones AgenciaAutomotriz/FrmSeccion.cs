using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_AgenciaAutomotriz;
using Manejadores_AgenciaAutomotriz;

namespace Presentaciones_AgenciaAutomotriz
{
    public partial class FrmSeccion : Form
    {
        public FrmSeccion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (true)
            { 
                Controlarlogin(true, true);
            
                FrmPrincipal u = new FrmPrincipal();
                u.ShowDialog();
            }

        }
        private void Controlarlogin(bool Usuario, bool Contra)
        {
                txtUsuario.Enabled = Usuario;
            txtContraseña.Enabled = Contra;
           
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (true)
            {
                Controlarlogin(true, true);

                FrmPrincipal u = new FrmPrincipal();
                u.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
