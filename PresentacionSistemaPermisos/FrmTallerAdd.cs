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
    public partial class FrmTallerAdd : Form
    {
        ManejadorHerramientas manejadorHerramientas;
        public FrmTallerAdd()
        {
            InitializeComponent();
            manejadorHerramientas = new ManejadorHerramientas();
            if (!FrmTaller.herramienta.CodigoHerramienta.Equals(""))
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = FrmTaller.herramienta.CodigoHerramienta;
                txtNombre.Text = FrmTaller.herramienta.Nombre;
                txtMedida.Text = FrmTaller.herramienta.Medida;
                txtMarca.Text = FrmTaller.herramienta.Marca;
                txtDescripcion.Text = FrmTaller.herramienta.Descripcion;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            manejadorHerramientas.Guardar(new Herramientas(
                txtCodigo.Text, txtNombre.Text, txtMedida.Text, txtMarca.Text, txtDescripcion.Text));
            txtCodigo.Clear();
            txtNombre.Clear();
            txtMedida.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
        }
    }
}
