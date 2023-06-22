using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WorkWithFiles.Task2;
using static FinalTask.Task4;

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
                var dtNow = DateTime.Now;
                var delta = dtNow - dirInfo.CreationTime;
                if (delta > new TimeSpan(0, 30, 0))
                {
                    if (dirInfo.Exists)
                    {
                        var i = ShowFolders(dirInfo);
                        Console.WriteLine("До удаления: " + i);
                        dirInfo.Delete(true);
                        Console.WriteLine("Старые файлы и папки удалены.");
                        Console.WriteLine("Было освобождено: " + i);
                        Console.WriteLine("После удаления: " + ShowFolders(dirInfo.Parent));
                    }
                    else { Console.WriteLine("Такой папки нет."); }

                    Console.ReadKey();
                }
                ReadValue();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"У вас нет доступа.{ex}");
                Console.ReadKey();
            }
        }
    }
}
