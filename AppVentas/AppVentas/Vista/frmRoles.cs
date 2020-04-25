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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                var jointablas = from tbusua in db.tb_usuarios
                                 from rolesusuario in db.roles_usuario
                                 where tbusua.Id == rolesusuario.id_Rol_usuario

                                 select new
                                 {
                                     Id = tbusua.Id,
                                     Email = tbusua.email,
                                     tipo_rol = rolesusuario.tipo_rol
                                 };
                dgvVistaTabla.DataSource = jointablas.ToList();
            }
        }

        private void dgvVistaTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
