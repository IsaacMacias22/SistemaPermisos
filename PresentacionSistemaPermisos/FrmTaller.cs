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
        public FrmTaller()
        {
            InitializeComponent();
            manejadorHerramientas = new ManejadorHerramientas();
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
            FrmTallerAdd frmTallerAdd = new FrmTallerAdd();
            frmTallerAdd.ShowDialog();
            Actualizar();
        }
    }
}
