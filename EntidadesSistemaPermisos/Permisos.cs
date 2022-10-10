using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSistemaPermisos
{
    public class Permisos
    {
        public Permisos(int fkidUsuario, int fkidModulo, bool permisoAcceso, 
            bool permisoLectura, bool permisoEscritura, bool permisoEliminacion, bool permisoActualizacion)
        {
            FkidUsuario = fkidUsuario;
            FkidModulo = fkidModulo;
            PermisoAcceso = permisoAcceso;
            PermisoLectura = permisoLectura;
            PermisoEscritura = permisoEscritura;
            PermisoEliminacion = permisoEliminacion;
            PermisoActualizacion = permisoActualizacion;
        }

        public int FkidUsuario { get; set; }
        public int FkidModulo { get; set; }
        public bool PermisoAcceso { get; set; }
        public bool PermisoLectura { get; set; }
        public bool PermisoEscritura { get; set; }
        public bool PermisoEliminacion { get; set; }
        public bool PermisoActualizacion { get; set; }
    }
}
