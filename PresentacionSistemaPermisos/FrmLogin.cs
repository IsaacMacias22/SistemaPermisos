using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadoresSistemaPermisos;
using EntidadesSistemaPermisos;
namespace PresentacionSistemaPermisos
{
    public partial class FrmLogin : Form
    {
        ManejadorUsuarios manejadorUsuarios;
        public FrmLogin()
        {
            InitializeComponent();
            manejadorUsuarios = new ManejadorUsuarios();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios(0, mtxtUsuario.Text, "", "", "", "", "", mtxtPwd.Text);
            int x = manejadorUsuarios.Mostrar(usuario);
            if (x > 0)
                MessageBox.Show("Acceso concedido");
            else
                MessageBox.Show("Acceso denegado");
        }
    }
}
