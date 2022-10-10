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
    public partial class FrmRefaccionesAdd : Form
    {
        ManejadorProductos manejadorProductos;
        public FrmRefaccionesAdd()
        {
            InitializeComponent();
            manejadorProductos = new ManejadorProductos();
            if (!FrmRefacciones.producto.CodigoBarras.Equals(""))
            {
                txtCodigoBarras.Enabled = false;
                txtCodigoBarras.Text = FrmRefacciones.producto.CodigoBarras;
                txtDescripcion.Text = FrmRefacciones.producto.Descripcion;
                txtMarca.Text = FrmRefacciones.producto.Marca;
                txtNombre.Text = FrmRefacciones.producto.Nombre;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            manejadorProductos.Guardar(new Productos(
                txtCodigoBarras.Text, txtNombre.Text, txtDescripcion.Text, txtMarca.Text));

            txtCodigoBarras.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtNombre.Clear();
        }
    }
}
