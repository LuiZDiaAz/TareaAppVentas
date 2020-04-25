using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.Model;
using AppVentas.Vista.formulariosbusqueda;

namespace AppVentas.Vista.formulariosbusqueda
{
    public partial class frmBusquedas : Form
    {
        public frmBusquedas()
        {
            InitializeComponent();
        }


        private void frmBusquedas_Load(object sender, EventArgs e)
        {
            
        }

        void filtro()
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                String nombre = txtBusqueda.Text;


                var bucarProd = from tbprod in db.producto

                                where tbprod.nombreProducto.Contains(nombre)

                                select new
                                {
                                    Id = tbProd.idProducto,
                                    Nombre = tbProd.nombreProducto,
                                    Precio = tbProd.precioProducto
                                };
                dgvBusqueda.DataSource = bucarProd.ToList();
            }
        }
        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            String Id= dgvBusqueda.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvBusqueda.CurrentRow.Cells[1].Value.ToString();
            String Precio = dgvBusqueda.CurrentRow.Cells[2].Value.ToString();

            frmFormularioPadre.venta.txtCodigoPro.Text = Id;
            frmFormularioPadre.venta.txtNombrePro.Text = Nombre;
            frmFormularioPadre.venta.txtPrecioPro.Text = Precio;

            frmFormularioPadre.venta.txtCantidad.Focus();

        }

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dgvBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            enviar();
        }
        void enviar()
        {
            String Id = dgvBusqueda.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dgvBusqueda.CurrentRow.Cells[1].Value.ToString();
            String Precio = dgvBusqueda.CurrentRow.Cells[2].Value.ToString();

            frmFormularioPadre.venta.txtCodigoPro.Text = Id;
            frmFormularioPadre.venta.txtNombrePro.Text = Nombre;
            frmFormularioPadre.venta.txtPrecioPro.Text = Precio;

            frmFormularioPadre.venta.txtCantidad.Focus();
            this.Close();
        }

        private void dgvBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                enviar();
            }
        }
    }
}
