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
    public class ManejadorHerramientas : IManejador
    {
        AccesoHerramientas accesoHerramientas = new AccesoHerramientas();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("¿Estás seguro de borrar?"), "¡Atención!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                accesoHerramientas.Borrar(Entidad);
        }

        public void Guardar(dynamic Entidad)
        {
            accesoHerramientas.Guardar(Entidad);
            g.Mensaje("Herramienta guardada con éxito", "Aviso", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = accesoHerramientas.Mostrar(filtro).Tables["herramientas"];
            tabla.Columns.Insert(5, g.Boton("Editar", Color.FromArgb(33, 150, 243), Color.White));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red, Color.White));
            tabla.AutoResizeColumns();
        }
    }
}
