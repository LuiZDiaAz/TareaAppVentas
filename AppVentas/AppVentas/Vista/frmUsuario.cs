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

namespace AppVentas.Vista
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        tb_usuarios user = new tb_usuarios();

        void CargarDatos()
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                var tb_usuario = db.tb_usuarios;

                dgvUsuario.DataSource = db.tb_usuarios.ToList();
            }
        }

        void LimpiarDatos()
        {
            txtEmail.Text = "";
            txtEmail.Text = "";
        }
        private void bttnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarDatos();
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                user.email = txtEmail.Text;
                user.contrasena = txtContrasena.Text;

                db.tb_usuarios.Add(user);
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                String Id = dgvUsuario.CurrentRow.Cells[0].ToolTipText.ToString();
                int idC = int.Parse(Id);
                user = db.tb_usuarios.Where(VerificarID => VerificarID.Id == idC).First();
                user.email = txtEmail.Text;
                user.contrasena = txtContrasena.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Email = dgvUsuario.CurrentRow.Cells[1].Value.ToString();
            String Contra = dgvUsuario.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = Email;
            txtContrasena.Text = Contra;
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                String Id = dgvUsuario.CurrentRow.Cells[0].ToolTipText.ToString();

                user = db.tb_usuarios.Find(int.Parse(Id));
                db.tb_usuarios.Remove(user);
                db.SaveChanges();
            }
            CargarDatos();
            LimpiarDatos();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarDatos();
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
