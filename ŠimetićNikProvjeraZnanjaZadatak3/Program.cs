using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠimetićNikProvjeraZnanjaZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Upisite pozitivni broj: ");
            Console.ReadLine();
            a = Convert.ToInt32();
            if (a < 0)
            {
                Console.WriteLine("Broj neodgovara");
            }
            else
            {

            }
            Console.ReadKey();
        }
    }
}
