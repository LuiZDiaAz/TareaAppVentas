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
using AppVentas.Vista;

namespace AppVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnIniciar_Click(object sender, EventArgs e)
        {
            using (AppVentaBDEntities db = new AppVentaBDEntities())
            {
                var lista = from Usuario in db.tb_usuarios
                            where Usuario.email == txtUsuario.Text
                            && Usuario.contrasena == txtContraseña.Text
                            select Usuario;

                if (lista.Count() > 0)
                {
                    MessageBox.Show("Bienvenido");
                    frmMenu f = new frmMenu();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Informacion Incorrecta");
                }
            }
        }
    }
}
