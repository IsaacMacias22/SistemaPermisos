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
    public partial class FrmRefacciones : Form
    {
        ManejadorProductos manejadorProductos;
        public static Productos producto = new Productos("", "", "", "");
        int fila = 0, col = 0;
        bool eliminar = true, actualizar = true;
        public FrmRefacciones(Permisos permiso)
        {
            InitializeComponent();
            manejadorProductos = new ManejadorProductos();
            RevisarPermisos(permiso);
        }
        void RevisarPermisos(Permisos permiso)
        {
            if (permiso.PermisoLectura == false)
            {
                dtgProductos.Visible = false;
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
            manejadorProductos.Mostrar(dtgProductos, txtBuscar.Text);
        }

        private void FrmRefacciones_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto.CodigoBarras = "";
            FrmRefaccionesAdd frmRefaccionesAdd = new FrmRefaccionesAdd();
            frmRefaccionesAdd.ShowDialog();
            Actualizar();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto.CodigoBarras = dtgProductos.Rows[fila].Cells[0].Value.ToString();
            producto.Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            producto.Descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            producto.Marca = dtgProductos.Rows[fila].Cells[3].Value.ToString();
            switch (col)
            {
                case 4:
                    {
                        if (actualizar)
                        {
                            FrmRefaccionesAdd frmRefaccionesAdd = new FrmRefaccionesAdd();
                            frmRefaccionesAdd.ShowDialog();
                            Actualizar();
                        }
                    } break;
                case 5:
                    {
                        if (eliminar)
                        {
                            manejadorProductos.Borrar(producto);
                            Actualizar();
                        }
                    } break;
            }
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
    }
}
