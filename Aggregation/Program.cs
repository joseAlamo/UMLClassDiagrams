using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Alumno
        {
        }

        class Maestro
        {
            public Alumno[] obtenAlumnos()
            {
                Alumno[] alumnos = new Alumno[10];
                return alumnos;
            }
        }

        class Calificacion
        {
        }

        class Materia
        {
            public Alumno MejorAlumno { get; set; }
            public Calificacion Promedio { get; set; }
        }
    }
}
