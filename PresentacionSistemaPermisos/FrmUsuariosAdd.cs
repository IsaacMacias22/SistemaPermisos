using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesSistemaPermisos;
using ManejadoresSistemaPermisos;
namespace PresentacionSistemaPermisos
{
    public partial class FrmUsuariosAdd : Form
    {
        ManejadorUsuarios manejadorUsuarios;
        public FrmUsuariosAdd()
        {
            InitializeComponent();
            manejadorUsuarios = new ManejadorUsuarios();
            if(FrmUsuarios.usuario.IdUsuario > 0)
            {
                lblUsuarios.Text = "Actualizar usuario";
                txtUsuario.Text = FrmUsuarios.usuario.Usuario;
                txtPassword.Text = FrmUsuarios.usuario.Pwd;
                txtNombre.Text = FrmUsuarios.usuario.Nombre;
                txtApellidop.Text = FrmUsuarios.usuario.Apellidop;
                txtApellidom.Text = FrmUsuarios.usuario.Apellidom;
                mtxtRfc.Text = FrmUsuarios.usuario.Rfc;
                dtpFdn.Value = Convert.ToDateTime(FrmUsuarios.usuario.FechaNacimiento);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            manejadorUsuarios.Guardar(new Usuarios(
                FrmUsuarios.usuario.IdUsuario, txtUsuario.Text, txtNombre.Text, txtApellidom.Text, txtApellidop.Text,
                dtpFdn.Value.ToString("yyyy-MM-dd"), mtxtRfc.Text, txtPassword.Text));
           
            txtUsuario.Clear();
            txtPassword.Clear();
            txtNombre.Clear();
            txtApellidop.Clear();
            txtApellidom.Clear();
            mtxtRfc.Clear();
            dtpFdn.Text = "";
        }
    }
}
