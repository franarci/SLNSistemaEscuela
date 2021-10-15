using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEscuela.Models
{
    public sealed class Alumno:Persona
    {
       
        public int NroLegajo { get; set; }

        public Alumno(string nombre, string apellido, int dni, DateTime fechaNac, int nroLegajo):base(nombre,apellido,dni,fechaNac)
        {
            NroLegajo = nroLegajo;
        }
    }
}
