using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA200921_2
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //for (int i = 0; i < 40; i++)
            //{
            //    for (int z = 0; z < i; z++)
            //    {
            //        Console.WriteLine();
            //    }
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine("Juhász Zoltán");
            //    Thread.Sleep(200);
            //    Console.Clear();
            //}

            string nev = "Juhász Zoltán";

            for (int i = 0; i < 40; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth - nev.Length),
                    rnd.Next(Console.WindowHeight));
                Console.WriteLine(nev);
                //Thread.Sleep(200);
                //Console.Clear();
            }




            Console.ReadKey();

        }
    }
}
