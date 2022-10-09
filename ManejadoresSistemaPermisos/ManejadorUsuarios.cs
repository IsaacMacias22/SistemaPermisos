using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosSistemaPermisos;
namespace ManejadoresSistemaPermisos
{
    public class ManejadorUsuarios : IManejador
    {
        AccesoUsuarios accesoUsuarios = new AccesoUsuarios();
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            throw new NotImplementedException();
        }

        public int Mostrar(dynamic Entidad)
        {
            return accesoUsuarios.Mostrar(Entidad);
        }
    }
}
