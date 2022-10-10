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
    public partial class FrmPermisos : Form
    {
        ManejadorPermisos manejadorPermisos;
        Permisos permiso = new Permisos(0,0,false,false,false,false,false);
        public FrmPermisos()
        {
            InitializeComponent();
            manejadorPermisos = new ManejadorPermisos();
        }
        void Actualizar()
        {
            manejadorPermisos.Mostrar(dtgPermisos, txtBuscar.Text);
        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            permiso.FkidUsuario = -1;
            permiso.FkidModulo = -1;
            FrmPermisosAdd frmPermisosAdd = new FrmPermisosAdd();
            frmPermisosAdd.ShowDialog();
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
