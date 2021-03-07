using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("App 2");
             
            int result = MyMath.Add(5, 6);
            Console.WriteLine("5 + 6 =" + result);
            Console.ReadLine();
            */
#if DEBUG
            Console.WriteLine(1);
#endif


#if RELEASE
            Console.WriteLine(1);
#endif
        }


    }
}
