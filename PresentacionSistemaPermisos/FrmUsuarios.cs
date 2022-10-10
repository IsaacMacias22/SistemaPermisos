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
        int fila = 0, col = 0;
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

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario.IdUsuario = int.Parse(dtgUsuarios.Rows[fila].Cells[0].Value.ToString());
            usuario.Usuario = dtgUsuarios.Rows[fila].Cells[1].Value.ToString();
            usuario.Nombre = dtgUsuarios.Rows[fila].Cells[2].Value.ToString();
            usuario.Apellidop = dtgUsuarios.Rows[fila].Cells[3].Value.ToString();
            usuario.Apellidom = dtgUsuarios.Rows[fila].Cells[4].Value.ToString();
            usuario.FechaNacimiento = dtgUsuarios.Rows[fila].Cells[5].Value.ToString();
            usuario.Rfc = dtgUsuarios.Rows[fila].Cells[6].Value.ToString();
            usuario.Pwd = dtgUsuarios.Rows[fila].Cells[7].Value.ToString();
            switch (col)
            {
                case 8:
                    {
                        FrmUsuariosAdd frmUsuariosAdd = new FrmUsuariosAdd();
                        frmUsuariosAdd.ShowDialog();
                        Actualizar();
                    } break;
                case 9:
                    {
                        manejadorUsuarios.Borrar(usuario);
                        Actualizar();
                    } break;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
        }
    }
}
