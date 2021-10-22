using Practica1_FSCH_Library;
using System;

namespace Practica1_FSCH
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(Practica1FSCH.Sum(i, 7));

            for (int i=0; i <= 10; i++)
            Console.WriteLine( Practica1FSCH.Substract(i, 4));
        }
    }
}
