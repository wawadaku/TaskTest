using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = new List<string>();
            array.Add(" ");
            array.Add(" ");
            array.Add(" ");
            array.Add(" ");
            array.Add(" ");
            array.Add(" ");
            array.Add(" ");
            array.Add(" ");
            for (int i = 8; i > 0; i--)
            {
                string str = string.Join(" ", array);
                Console.WriteLine($"{str}********");
                Console.WriteLine();
                array.RemoveAt(i-1);
            }
            Console.ReadKey();
        }
    }
}
