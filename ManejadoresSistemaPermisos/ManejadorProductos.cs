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
    public class ManejadorProductos : IManejador
    {
        AccesoProductos accesoProductos = new AccesoProductos();
        Grafico g = new Grafico();
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            accesoProductos.Guardar(Entidad);
            g.Mensaje("Producto guardado con éxito", "Aviso", MessageBoxIcon.Information);
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = accesoProductos.Mostrar(filtro).Tables["productos"];
            tabla.Columns.Insert(4, g.Boton("Editar", Color.FromArgb(33, 150, 243), Color.White));
            tabla.Columns.Insert(5, g.Boton("Borrar", Color.Red, Color.White));
            tabla.AutoResizeColumns();
        }
    }
}
