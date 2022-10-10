using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
namespace AccesoDatosSistemaPermisos
{
    public class AccesoProductos : IEntidades
    {
        Base b = new Base("localhost", "root", "", "sistemapermisos");
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertOrUpdateProductos('{0}', '{1}', '{2}', '{3}')",
                Entidad.CodigoBarras, Entidad.Nombre, Entidad.Descripcion, Entidad.Marca));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call p_showProductos('%{0}%')",filtro),"productos");
        }
    }
}
