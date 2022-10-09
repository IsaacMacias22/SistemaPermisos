using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoDatosSistemaPermisos
{
    public class AccesoUsuarios : IEntidades
    {
        Base b = new Base("localhost", "root", "", "sistemapermisos");
        public void Borrar(dynamic Entidad)
        {
            throw new NotImplementedException();
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call p_insertOrUpdateUsuario({0},'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                Entidad.IdUsuario, Entidad.Usuario, Entidad.Nombre, Entidad.Apellidop, Entidad.Apellidom,
                Entidad.FechaNacimiento, Entidad.Rfc, Entidad.Pwd));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call p_showUsuarios('%{0}%')",filtro),"usuarios");
        }
        public int Mostrar(dynamic Entidad)
        {
            DataSet ds = b.Obtener(string.Format(
                "SELECT COUNT(*) Numero FROM usuarios WHERE usuario = '{0}' AND pwd = '{1}'",Entidad.Usuario,Entidad.Pwd),"usuarios");
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            int x = 0;
            DataRow row = dt.Rows[0];
            x = int.Parse(row["Numero"].ToString());
            return x;
        }
    }
}
