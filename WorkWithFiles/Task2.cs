using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFiles
{
    internal class Task2
    {
        public static long ShowFolders(DirectoryInfo d)
        {
            long i = 0;
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo File in Files)
            {
                i += File.Length;
            }
            DirectoryInfo[] dirs = d.GetDirectories();
            foreach (DirectoryInfo Directory in dirs)
            {
                i += ShowFolders(Directory);
            }
            return i;
        }

    }
}
