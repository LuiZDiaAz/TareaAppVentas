using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentas.Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario f = new frmUsuario();
            f.Show();
        }

        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles f = new frmRoles();
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFormularioPadre f = new frmFormularioPadre();
            f.Show();
        }
    }
}
