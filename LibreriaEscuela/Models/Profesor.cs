using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEscuela.Models
{
    public class Profesor:Persona
    {
        public string Titulo { get; set; }

        public Profesor(string nombre, string apellido, int dni, DateTime fechaNac, string titulo) : base(nombre, apellido, dni, fechaNac)
        {
            Titulo = titulo;
        }
    }
}
