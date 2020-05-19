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
    public partial class frmFormularioPadre : Form
    {
        public frmFormularioPadre()
        {
            InitializeComponent();
        }

        public static frmVentas venta = new frmVentas();
        private void bttnBuscarr_Click(object sender, EventArgs e)
        {
            venta.MdiParent = this;
            venta.Show();
        }

        private void frmFormularioPadre_Load(object sender, EventArgs e)
        {

        }
    }
}
