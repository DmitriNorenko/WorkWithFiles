using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    internal class Task4
    {
        static string SettingsFileName = "/Users/dima/Desktop/Students.dat";
        public static void ReadValues()
        {
            string Name;
            string Group;
            DateTime DateOfBirth;

            if (File.Exists(SettingsFileName))
            {

                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    Name = reader.ReadString();
                    Group = reader.ReadString();
                    DateOfBirth = Convert.ToDateTime(reader.ReadString());
                }
                Console.WriteLine(Name);
                Console.WriteLine(Group);
                Console.WriteLine(DateOfBirth);
            }
           
        }
    }
}
