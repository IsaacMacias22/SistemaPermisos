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
        public static Permisos permiso = new Permisos(0,0,false,false,false,false,false);
        public static string usuario = "";
        public static string modulo = "";
        int fila = 0, col = 0;
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

        private void dtgPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = dtgPermisos.Rows[fila].Cells[2].Value.ToString();
            modulo = dtgPermisos.Rows[fila].Cells[3].Value.ToString();
            permiso.FkidUsuario = int.Parse(dtgPermisos.Rows[fila].Cells[0].Value.ToString());
            permiso.FkidModulo = int.Parse(dtgPermisos.Rows[fila].Cells[1].Value.ToString());
            permiso.PermisoAcceso = bool.Parse(dtgPermisos.Rows[fila].Cells[4].Value.ToString());
            permiso.PermisoLectura = bool.Parse(dtgPermisos.Rows[fila].Cells[5].Value.ToString());
            permiso.PermisoEscritura = bool.Parse(dtgPermisos.Rows[fila].Cells[6].Value.ToString());
            permiso.PermisoEliminacion = bool.Parse(dtgPermisos.Rows[fila].Cells[7].Value.ToString());
            permiso.PermisoActualizacion = bool.Parse(dtgPermisos.Rows[fila].Cells[8].Value.ToString());
            switch (col)
            {
                case 9:
                {
                    FrmPermisosAdd frmPermisosAdd = new FrmPermisosAdd();
                    frmPermisosAdd.ShowDialog();
                    Actualizar();
                } break;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgPermisos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
    }
}
