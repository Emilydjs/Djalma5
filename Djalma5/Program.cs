using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djalma5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("contador de pares");
            for (int i = 2; i <= 100; i = i + 2) 
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
