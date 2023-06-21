using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WorkWithFiles.Task2;

namespace WorkWithFiles
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "/Users/dima/tests/";
                DirectoryInfo dirInfo = new DirectoryInfo(str);

                if (dirInfo.Exists)
                {
                    Console.WriteLine("До удаления: " + ShowFolders(dirInfo));
                    dirInfo.Delete(true);
                    Console.WriteLine("Старые файлы и папки удалены.");
                    Console.WriteLine("Освобождено места: " + ShowFolders(dirInfo));
                    Console.WriteLine("После удаления: " + ShowFolders(dirInfo));
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"У вас нет доступа.{ex}");
                Console.ReadKey();
            }
        }
    }
}
