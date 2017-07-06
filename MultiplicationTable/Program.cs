using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("\t*\t*\t*\t九九の表\t*\t*\t*");
            Console.Write("\t|");
            for (i = 1; i < 10; i++)
            {
                Console.Write("\t" + i);
            }
            Console.Write("\n");
            for (i = 0; i < 90; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");

            Multiplication();

            Console.WriteLine("終了するには何かを押してください。");
            Console.Read();
        }

        static void Multiplication()
        {
            int i, j;
            for (i = 1; i < 10; i++)
            {
                Console.Write(i + "\t|");
                for (j = 1; j < 10; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.Write("\n");
            }
        }
    }
}
