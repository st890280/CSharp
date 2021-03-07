using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFileReader
{
    class TestFileReader
    {
        /// <summary>
        /// 讀取檔案，不存在時回傳空字串
        /// </summary>
        /// <param name="path">檔案路徑</param>
        /// <returns></returns>
        public static void Append(string path, string content)
        {
            
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} doesn't exist;");
                Console.ReadLine();
                return;
            }

            string cTime = DateTime.Now.ToString("yyyy/MM/ddHH:mm:ss");
            content = System.Environment.NewLine + "[" + cTime + "]" + content;

            File.AppendAllText(path, content);

            //string content = File.ReadAllText(path);
            //return content;
        }
    }
}
