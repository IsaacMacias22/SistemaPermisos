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
    public partial class FrmTaller : Form
    {
        ManejadorHerramientas manejadorHerramientas;
        public static Herramientas herramienta = new Herramientas("","","","","");
        int fila = 0, col = 0;
        bool eliminar = true, actualizar = true;
        public FrmTaller(Permisos permiso)
        {
            InitializeComponent();
            manejadorHerramientas = new ManejadorHerramientas();
            RevisarPermisos(permiso);
        }
        void RevisarPermisos(Permisos permiso)
        {
            if (permiso.PermisoLectura == false)
            {
                dtgHerramientas.Visible = false;
                txtBuscar.Visible = false;
            }
            if (permiso.PermisoEscritura == false)
                btnAgregar.Visible = false;
            if (permiso.PermisoEliminacion == false)
                eliminar = false;
            if (permiso.PermisoActualizacion == false)
                actualizar = false;
        }
        void Actualizar()
        {
            manejadorHerramientas.Mostrar(dtgHerramientas, txtBuscar.Text);
        }

        private void FrmTaller_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            herramienta.CodigoHerramienta = "";
            FrmTallerAdd frmTallerAdd = new FrmTallerAdd();
            frmTallerAdd.ShowDialog();
            Actualizar();
        }

        private void dtgHerramientas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            herramienta.CodigoHerramienta = dtgHerramientas.Rows[fila].Cells[0].Value.ToString();
            herramienta.Nombre = dtgHerramientas.Rows[fila].Cells[1].Value.ToString();
            herramienta.Medida = dtgHerramientas.Rows[fila].Cells[2].Value.ToString();
            herramienta.Marca = dtgHerramientas.Rows[fila].Cells[3].Value.ToString();
            herramienta.Descripcion = dtgHerramientas.Rows[fila].Cells[4].Value.ToString();
            switch (col)
            {
                case 5:
                    {
                        if (actualizar)
                        {
                            FrmTallerAdd frmTallerAdd = new FrmTallerAdd();
                            frmTallerAdd.ShowDialog();
                            Actualizar();
                        }
                    } break;
                case 6:
                    {
                        if (eliminar)
                        {
                            manejadorHerramientas.Borrar(herramienta);
                            Actualizar();
                        }
                    } break;
            }
        }

        private void dtgHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
    }
}
