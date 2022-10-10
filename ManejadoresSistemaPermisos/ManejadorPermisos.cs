using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD;
using AccesoDatosSistemaPermisos;
using System.Drawing;

namespace ManejadoresSistemaPermisos
{
    public class ManejadorPermisos : IManejador
    {
        AccesoUsuarios accesoUsuarios = new AccesoUsuarios();
        AccesoPermisos accesoPermisos = new AccesoPermisos();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            //throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            accesoPermisos.Guardar(Entidad);
            g.Mensaje("Permisos guardados con éxito", "Aviso", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = accesoPermisos.Mostrar(filtro).Tables["permisos"];
            tabla.Columns.Insert(9, g.Boton("Editar", Color.FromArgb(33, 150, 243), Color.White));
            //tabla.Columns.Insert(10, g.Boton("Borrar", Color.Red, Color.White));
            tabla.Columns[0].Visible = false;
            tabla.Columns[1].Visible = false;
            tabla.AutoResizeColumns();
        }
        public void ExtraerUsuarios(ComboBox caja)
        {
            caja.DataSource = accesoUsuarios.Mostrar("").Tables["usuarios"];
            caja.DisplayMember = "usuario";
            caja.ValueMember = "idusuario";
        }
    }
}
