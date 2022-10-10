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
    public partial class FrmPermisosAdd : Form
    {
        ManejadorPermisos manejadorPermisos;
        bool acceso = false, lectura = false, escritura = false, eliminacion = false, actualizacion = false;
        public FrmPermisosAdd()
        {
            InitializeComponent();
            manejadorPermisos = new ManejadorPermisos();
            manejadorPermisos.ExtraerUsuarios(cmbUsuarios);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbUsuarios.SelectedValue.ToString());
            ComprobarPermisos();

            manejadorPermisos.Guardar(new Permisos(
                int.Parse(cmbUsuarios.SelectedValue.ToString()), cmbModulo.SelectedIndex+1,
                acceso, lectura, escritura, eliminacion, actualizacion
                ));

            cmbUsuarios.SelectedItem = null;
            cmbModulo.SelectedItem = null;
            chkAcceso.Checked = false;
            chkLectura.Checked = false;
            chkEscritura.Checked = false;
            chkEliminacion.Checked = false;
            chkActualizacion.Checked = false;
        }
        void ComprobarPermisos()
        {
            if (chkAcceso.Checked)
                acceso = true;
            if (chkLectura.Checked)
                lectura = true;
            if (chkEscritura.Checked)
                escritura = true;
            if (chkEliminacion.Checked)
                eliminacion = true;
            if (chkActualizacion.Checked)
                actualizacion = true;
        }
    }
}
