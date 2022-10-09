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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios manejadorUsuarios;
        public static Usuarios usuario = new Usuarios(0,"","","","","","","");
        public FrmUsuarios()
        {
            InitializeComponent();
            manejadorUsuarios = new ManejadorUsuarios();
        }
        void Actualizar()
        {
            manejadorUsuarios.Mostrar(dtgUsuarios, txtBuscar.Text);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            usuario.IdUsuario = -1;
            FrmUsuariosAdd frmUsuariosAdd = new FrmUsuariosAdd();
            frmUsuariosAdd.ShowDialog();
            Actualizar();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
