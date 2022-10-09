using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSistemaPermisos
{
    public class Usuarios
    {
        public Usuarios(int idUsuario, string usuario, string nombre, string apellidop,
            string apellidom, string fechaNacimiento, string rfc, string pwd)
        {
            IdUsuario = idUsuario;
            Usuario = usuario;
            Nombre = nombre;
            Apellidop = apellidop;
            Apellidom = apellidom;
            FechaNacimiento = fechaNacimiento;
            Rfc = rfc;
            Pwd = pwd;
        }

        public int IdUsuario  { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string Apellidom { get; set; }
        public string FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Pwd { get; set; }
    }
}
