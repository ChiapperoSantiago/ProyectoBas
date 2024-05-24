using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Persona
    {
        private string Nombre;
        private string Apellido;
        private string Documento;
        public Persona(string nombre, string apellido, string documento)
        {
            Nombre = nombre;
            Apellido = apellido ;
            Documento = documento ;
        }
        public string NombreDePersona
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string ApellidoDePersona
        {
            get => Apellido;
            set => Apellido = value;
        }
        public string DocumentoDePersona
        {
            get => Documento;
            set => Documento = value;
        }
    }
}
