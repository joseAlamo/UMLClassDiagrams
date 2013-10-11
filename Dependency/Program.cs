using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        class OperatingSystem
        {
            public OSBootLoader Boot { get; set; }

            public int bootSystem(OSBootLoader boot)
            {
                return 1;
            }
        }

        class OSBootLoader
        {
            public string BootStuff { get; set; }
            public string LoadStuff { get; set; }

            public void execBoot()
            {
            }
        }
    }
}
