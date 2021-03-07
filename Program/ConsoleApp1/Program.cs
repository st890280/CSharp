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
            int[] array = new int[]
            {
                1,2,3,4,5,6
            };



            Console.WriteLine(" " + array[0]);
            for (int i = 0; i < array.Length; i++)
             {
                Console.WriteLine(" " + array[i]);
             }
            Console.Read();

            foreach (string item in args)
            {
                Console.WriteLine($" {item}");
            }
            Console.ReadLine();
        }
      
    }
}
