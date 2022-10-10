using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosSistemaPermisos
{
    public class AccesoHerramientas : IEntidades
    {
        Base b = new Base("localhost", "root", "", "sistemapermisos");
        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_deleteHerramientas('{0}')", Entidad.CodigoHerramienta));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertOrUpdateHerramientas('{0}', '{1}', '{2}', '{3}', '{4}')",
                Entidad.CodigoHerramienta, Entidad.Nombre, Entidad.Medida, Entidad.Marca, Entidad.Descripcion));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call p_showHerramientas('%{0}%')",filtro),"herramientas");
        }
    }
}
