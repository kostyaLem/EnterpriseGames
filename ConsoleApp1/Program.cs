using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 9;
            int rowLenght = 10;

            for (int i = 0; i <= 18; i++)
            {
                if (i <= 9)
                    Console.WriteLine(new string('%', rowLenght - count--));
                else
                    Console.WriteLine(new string('%', rowLenght - count++));
            }

            Console.ReadKey();
        }
    }
}
