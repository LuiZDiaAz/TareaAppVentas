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
        frmUsuario f = new frmUsuario();
        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.Show();
        }
        frmRoles form = new frmRoles();
        private void rOLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Show();
        }
        frmFormularioPadre formu = new frmFormularioPadre();
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formu.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
