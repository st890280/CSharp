using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\cs2019\\LessonPratice\\CSHARP\\";
            string fileName = "AAA.txt";
            /*
           if (System.IO.File.Exists(path + fileName))
           {
               Console.WriteLine($"{path}{fileName} 不存在;");
               Console.ReadLine();
               return;

           }
            
            //string content = System.IO.File.ReadAllText(path + fileName);

            string content = "Hello World";
            TestFileReader.WriteFile(path + fileName, content);
            Console.WriteLine(content);
            Console.ReadLine();
            */
            TestFolderReader.CreateFolder(path);
        }

    }
}
