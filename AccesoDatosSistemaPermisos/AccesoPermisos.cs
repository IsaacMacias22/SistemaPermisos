using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesSistemaPermisos;
namespace AccesoDatosSistemaPermisos
{
    public class AccesoPermisos : IEntidades
    {
        Base b = new Base("localhost", "root", "", "sistemapermisos");
        public void Borrar(dynamic Entidad)
        {
            //throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertOrUpdatePermisos({0}, {1}, {2}, {3}, {4}, {5}, {6})",
                Entidad.FkidUsuario, Entidad.FkidModulo, Entidad.PermisoAcceso, Entidad.PermisoLectura,
                Entidad.PermisoEscritura, Entidad.PermisoEliminacion, Entidad.PermisoActualizacion));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call p_showPermisos('%{0}%')", filtro), "permisos");
        }
        public List<Permisos> GetPermisos(string dato)
        {
            var listPermisos = new List<Permisos>();
            var ds = new DataSet();

            ds = b.Obtener(string.Format("call p_showPermisos('%{0}%')",dato),"permisos");

            var dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                Permisos permiso = new Permisos(
                    int.Parse(row["idusuario"].ToString()),
                    int.Parse(row["idmodulo"].ToString()),
                    bool.Parse(row["permisoAcceso"].ToString()),
                    bool.Parse(row["permisoLectura"].ToString()),
                    bool.Parse(row["permisoEscritura"].ToString()),
                    bool.Parse(row["permisoEliminacion"].ToString()),
                    bool.Parse(row["permisoActualizacion"].ToString()));
                listPermisos.Add(permiso);
            }
            return listPermisos;
        }
    }
}
