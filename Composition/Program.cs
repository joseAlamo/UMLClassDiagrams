using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class Pajaro
        {
            public AlaDerecha alaD { get; set; }
            public AlaIzquierda alaI { get; set; }
        }

        class AlaDerecha
        {
        }

        class AlaIzquierda
        {
        }
    }
}
