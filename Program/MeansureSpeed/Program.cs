using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            Console.WriteLine("程式開始");
            sw.Start();
            SleepHelper.SleepAWhile(Rnd);
            sw.Stop();



            sw.Start();
            SleepHelper.SleepAWhile(Rnd);
            sw.Stop();

            Console.WriteLine("程式結束. 用時 " + sw.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
