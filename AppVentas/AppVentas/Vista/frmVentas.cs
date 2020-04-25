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

namespace AppVentas.Vista
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        void RetornoId()
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                var tb_V = db.tb_venta;

                foreach(var iterardatosventa in tb_V)
                {
                    txtIdNumeracion.Text = iterardatosventa.idVenta.ToString();
                }
            }
        }

        void CargarCombo()
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                var Clientes = db.tb_cliente.ToList();

                cmbCliente.DataSource = Clientes;
                cmbCliente.DisplayMember = "nombreCliente";
                cmbCliente.ValueMember = "IDCliente";

                var tipoDocu = db.tb_documento.ToList();

                cmbTipodocu.DataSource = tipoDocu;
                cmbTipodocu.DisplayMember = "nombreDocumento";
                cmbTipodocu.ValueMember = "IDDocumento";
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

            RetornoId();
            CargarCombo();
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedas busqueda = new frmBusquedas();
            busqueda.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            dgvVentas.Rows.Add(txtCodigoPro.Text,txtNombrePro.Text,txtPrecioPro.Text,txtCantidad.Text,txtTotal.Text);
            try
            {
                calculo();
            }
            catch(Exception ex)
            {

            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }
        void calculo() {
            try
            {
                Double PrecioProd;
                Double Cantidad;
                Double Total;

                PrecioProd = Double.Parse(txtPrecioPro.Text);
                Cantidad = Convert.ToDouble(txtCantidad.Text);

                Total = PrecioProd * Cantidad;

                txtTotal.Text = Total.ToString();
            }
            catch (Exception ex)
            {
                txtCantidad.Text = "0";
                MessageBox.Show("No se puede agregar datos menos a 0");
                txtCantidad.Select();
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
