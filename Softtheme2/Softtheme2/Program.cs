using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softtheme2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            number =  Int32.Parse(Console.ReadLine());
            for (int k = number; k > 0; k--)
            {
                if (number % k == 0)
                    Console.Write(k + " ");
            }
            Console.Read();
        }
    }
}
