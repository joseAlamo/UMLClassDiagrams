using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Chef
        {
            public Especialidad especialidad { get; set; }

            public void favDelChef(Especialidad esp)
            {

            }
        }

        class Especialidad
        {
            public string Ingredientes { get; set; }
        }
    }
}
