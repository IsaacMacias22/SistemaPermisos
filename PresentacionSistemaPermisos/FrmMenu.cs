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
    public partial class FrmMenu : Form
    {
        ManejadorPermisos manejadorPermisos;
        List<Permisos> permisos;
        Permisos permisosTaller;
        Permisos permisosRefacciones;
        public FrmMenu(Usuarios usuario)
        {
            InitializeComponent();
            manejadorPermisos = new ManejadorPermisos();
            if (!usuario.Usuario.Equals("Administrador"))
            {
                optUsuarios.Visible = false;
                optPermisos.Visible = false;
                optRefacciones.Visible = false;
                optTaller.Visible = false;
                RevisarPermisos(usuario);
            }
            else
            {
                permisosRefacciones = new Permisos(usuario.IdUsuario, 1,
                true, true, true, true, true);
                permisosTaller = new Permisos(usuario.IdUsuario, 2,
                    true, true, true, true, true);
            }
        }
        void RevisarPermisos(Usuarios usuario)
        {
            permisos = manejadorPermisos.GetPermisos(usuario.Usuario);
            foreach (var item in permisos)
            {
                if (item.FkidModulo == 1 && item.PermisoAcceso == true)
                {
                    optRefacciones.Visible = true;
                    permisosRefacciones = new Permisos(usuario.IdUsuario, 1,
                        item.PermisoAcceso, item.PermisoLectura, item.PermisoEscritura,
                        item.PermisoEliminacion, item.PermisoActualizacion);
                }
                if (item.FkidModulo == 2 && item.PermisoAcceso == true)
                {
                    optTaller.Visible = true;
                    permisosTaller = new Permisos(usuario.IdUsuario, 2,
                        item.PermisoAcceso, item.PermisoLectura, item.PermisoEscritura,
                        item.PermisoEliminacion, item.PermisoActualizacion);
                }
            }
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void optUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios formUsuarios = new FrmUsuarios();
            formUsuarios.ShowDialog();
            formUsuarios.MdiParent = this;
        }

        private void optPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisos frmPermisos = new FrmPermisos();
            frmPermisos.ShowDialog();
            frmPermisos.MdiParent = this;
        }

        private void optHerramientas_Click(object sender, EventArgs e)
        {
            FrmTaller frmTaller = new FrmTaller(permisosTaller);
            frmTaller.ShowDialog();
            frmTaller.MdiParent = this;
        }

        private void optRefacciones_Click(object sender, EventArgs e)
        {
            FrmRefacciones frmRefacciones = new FrmRefacciones(permisosRefacciones);
            frmRefacciones.ShowDialog();
            frmRefacciones.MdiParent = this;
        }
    }
}
