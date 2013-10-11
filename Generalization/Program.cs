using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Perro
        {
            public int Edad { get; set; }
            public bool Vacunas { get; set; }
            public string Color { get; set; }
        }

        class Husky : Perro
        {
            
        }
    }
}
