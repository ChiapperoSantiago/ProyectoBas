using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Usuario
    {
        private string NombreUser;
        private string Contraseña;
        public Usuario(string nombreUser, string contraseña)
        {
            NombreUser = nombreUser;
            Contraseña = contraseña;
        }
        public string NombreDeUsuario
        {
            get => NombreUser;
            set => NombreUser = value;
        }
        public string Contrasenia 
        {
            get => Contraseña;
            set => Contraseña = value;
        }
    }
}
