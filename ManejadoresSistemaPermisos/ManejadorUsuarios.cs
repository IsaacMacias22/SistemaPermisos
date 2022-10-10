using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosSistemaPermisos;
using CRUD;
namespace ManejadoresSistemaPermisos
{
    public class ManejadorUsuarios : IManejador
    {
        AccesoUsuarios accesoUsuarios = new AccesoUsuarios();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Estás seguro de borrar?"), "¡Atención!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                accesoUsuarios.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            accesoUsuarios.Guardar(Entidad);
            g.Mensaje("Usuario guardado con éxito", "Aviso", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = accesoUsuarios.Mostrar(filtro).Tables["usuarios"];
            tabla.Columns.Insert(8, g.Boton("Editar", Color.FromArgb(33, 150, 243), Color.White));
            tabla.Columns.Insert(9, g.Boton("Borrar", Color.Red, Color.White));
            tabla.Columns[0].Visible = false;
            tabla.AutoResizeColumns();
        }

        public int Mostrar(dynamic Entidad)
        {
            return accesoUsuarios.Mostrar(Entidad);
        }
    }
}
