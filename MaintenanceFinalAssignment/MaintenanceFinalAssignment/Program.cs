#define defEnglish
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using RegEditTool;

namespace MaintenanceFinalAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
#if defEnglish
            int RegState = 0;
            RegEdit regedit = new RegEdit();
            foreach (string b in args)
            {
                if (b.Contains('-'))
                {
                    if (b == "-h")
                    {
                        Console.WriteLine("Command line arguments available\n-b Registery DLL Application\n");
                    }
                    else if (b == "-b")
                    {
                        RegState = regedit.Start();
                    }
                }
                else
                {
                    Console.WriteLine("Input argument {0} is not supported", b);
                }
            }
            regedit.End(RegState);
            if (args.Length == 0)
            {
                Console.WriteLine("Application closing because no arguments were given. use -h to see options.");
            }
            else
            {
                Console.WriteLine("\nApplication closing");
            }
#endif
        }
    }
}
