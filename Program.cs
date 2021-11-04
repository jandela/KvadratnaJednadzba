using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnaJednadzba
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(1, 2, -3);
            var roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);

            qe = new QuadraticEquation(-1, 2, -1);
            roots = qe.Roots;
            Console.WriteLine(roots[0]);
            Console.WriteLine(roots[1]);
            //Console.WriteLine(qe.A);
            //qe.A = 10;

            qe = new QuadraticEquation(1, 0, 1);
            try
            { 
                roots = qe.Roots;
                Console.WriteLine(roots[0]);
                Console.WriteLine(roots[1]);
            }
            catch(NotRealRootsException nrre)
            {
                Console.WriteLine("Roots don't have real values: {0}", nrre.Message);
            }

            Console.ReadKey(false);
        }

    }
}
