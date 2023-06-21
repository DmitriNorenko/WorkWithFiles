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
                string str = "/Tests/f";
                DirectoryInfo dirInfo = new DirectoryInfo(str);

                if (dirInfo.Exists)
                {
                    var i = ShowFolders(dirInfo);
                    Console.WriteLine("До удаления: " + i );
                    dirInfo.Delete(true);
                    Console.WriteLine("Старые файлы и папки удалены.");
                    Console.WriteLine("Было освобождено: " + i);
                    Console.WriteLine("После удаления: " + ShowFolders(dirInfo.Parent));
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
