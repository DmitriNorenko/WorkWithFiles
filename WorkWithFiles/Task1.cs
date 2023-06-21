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
                string str = "/Tests";
                DirectoryInfo directoryInfo = new DirectoryInfo(str);

                if (directoryInfo.Exists)
                {
                    directoryInfo.Delete(true);
                    Console.WriteLine("Старые файлы и папки удалены.");
                }
                Console.WriteLine(ShowFolders(directoryInfo));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"У вас нет доступа.{ex}");
            }
        }
    }
}
