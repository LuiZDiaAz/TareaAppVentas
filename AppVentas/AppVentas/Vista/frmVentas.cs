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
                txtIdNumeracion.Text = "1";
                foreach(var iterardatosventa in tb_V)
                {
                    int idVenta = iterardatosventa.idVenta;
                    int suma = idVenta + 1;
                    txtIdNumeracion.Text = suma.ToString();
                   
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
            try
            {
                calculo();
            }
            catch(Exception ex)
            {

            }

            dgvVentas.Rows.Add(txtCodigoPro.Text, txtNombrePro.Text, txtPrecioPro.Text, txtCantidad.Text, txtTotal.Text);
            Double suma = 0;
            for (int i=0;i<dgvVentas.RowCount;i++) {
                String datodAOperar = dgvVentas.Rows[i].Cells[4].Value.ToString();
                Double datosConvertidos = Convert.ToDouble(datodAOperar);
                //Double datosConvertidos1 = Double.Parse(datodAOperar);
                
                //suma = suma + datosConvertidos;
                suma += datosConvertidos;

                txtTotalFinal.Text = suma.ToString();

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
                txtCantidad.Text = "1";
                txtCantidad.Select();
                //MessageBox.Show(ex.ToString());
            }
        }

        private void bttnGuardarVenta_Click(object sender, EventArgs e)
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                tb_venta tb_v = new tb_venta();
                String comboTipoDoc = cmbTipodocu.SelectedValue.ToString();
                String comboCliente = cmbCliente.SelectedValue.ToString();
                tb_v.idDocumento = Convert.ToInt32(comboTipoDoc);
                tb_v.iDCliente = Convert.ToInt32(comboCliente);
                tb_v.iDUsuario = 1;
                tb_v.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                tb_v.fecha = Convert.ToDateTime(dtpFecha.Text);
                db.tb_venta.Add(tb_v);
                db.SaveChanges();


                detalleVenta dete = new detalleVenta();
                for (int i = 0; i < dgvVentas.RowCount; i++)
                {
                    String idProducto = dgvVentas.Rows[i].Cells[0].Value.ToString();
                    int idProductosConvertidos = Convert.ToInt32(idProducto);

                    String cantidad = dgvVentas.Rows[i].Cells[3].Value.ToString();
                    int cantidadConvertidos = Convert.ToInt32(cantidad);

                    String precio = dgvVentas.Rows[i].Cells[2].Value.ToString();
                    Decimal precioConvertidos = Convert.ToDecimal(precio);

                    String total = dgvVentas.Rows[i].Cells[4].Value.ToString();
                    Decimal totalConvertidos = Convert.ToInt32(total);

                    dete.idVenta = Convert.ToInt32(txtIdNumeracion.Text);
                    dete.idProducto = idProductosConvertidos;
                    dete.cantidad = cantidadConvertidos;
                    dete.precio = precioConvertidos;
                    dete.total = totalConvertidos;
                    db.detalleVenta.Add(dete);
                    db.SaveChanges();

                }

            }
            RetornoId();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtbusquedacodigobarra.Text == "")
            {
                if (e.KeyCode== Keys.Enter)
                {
                    bttnBuscar.PerformClick();
                }
            }else if(e.KeyCode == Keys.Enter)
            {
                using (AppVentaBDEntities db = new AppVentaBDEntities())
                {
                    producto pr = new producto();
                    int buscar = int.Parse(txtbusquedacodigobarra.Text);
                    pr = db.producto.Where(idBusqueda => idBusqueda.idProducto == buscar).First();
                    txtCodigoPro.Text = Convert.ToString(pr.idProducto);
                    txtNombrePro.Text = Convert.ToString(pr.nombreProducto);
                    txtPrecioPro.Text = Convert.ToString(pr.precioProducto);
                    txtCantidad.Focus();
                    txtbusquedacodigobarra.Text = "";
                }
            }
        }

        int intentos = 1;
        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (intentos == 2)
                {
                    btnadd.PerformClick();
                    txtCodigoPro.Text = "";
                    txtNombrePro.Text = "";
                    txtPrecioPro.Text = "";
                    txtTotal.Text = "";
                    intentos = 0;
                    txtCantidad.Text = "1";
                    txtbusquedacodigobarra.Focus();
                }
                intentos += 1;
            }
        }
    }
}
