using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaEscuela.Models;

namespace WindowsEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            Profesor profesor =
                new Profesor(
                     Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre"),
                     Microsoft.VisualBasic.Interaction.InputBox("Ingrese un apellido"),
                     Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un DNI")),
                     Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una fecha de nacimiento, Ej: 05 / 01 / 1996")),
                     Microsoft.VisualBasic.Interaction.InputBox("Ingrese un titulo")
                     );

            lstProfesores.Items.Add(profesor.Nombre + " " + profesor.Apellido + " DNI: " + profesor.DNI + " FechaNacimiento: " + Convert.ToString(profesor.FechaNacimiento) + " " + profesor.Titulo);
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno =
                new Alumno(
                     Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre"),
                     Microsoft.VisualBasic.Interaction.InputBox("Ingrese un apellido"),
                     Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un DNI")),
                     Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una fecha de nacimiento, Ej: 05 / 01 / 1996")),
                     Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un legajo"))
                     );

            lstAlumnos.Items.Add(alumno.Nombre + " " + alumno.Apellido + " DNI: " + alumno.DNI + " FechaNacimiento: " + Convert.ToString(alumno.FechaNacimiento) + " " + alumno.NroLegajo);
        }
    }
}
