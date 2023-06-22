using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    [Serializable]
    internal class Task4
    {
        public string Name { get; set; }
        public string Group { get; set; }


        public Task4(string name, string group, DateTime date)
        {
            Name = name;
            Group = group;

        }

        static string FileName = "/Users/dima/Desktop/Students.dat";
        public static void ReadValue()
        {
            BinaryFormatter bf = new BinaryFormatter();
            var fs = new FileStream(FileName, FileMode.OpenOrCreate);
            var students = (Task4)bf.Deserialize(fs);
            Console.WriteLine(" Имя: {0} \n Группа: {1} \n Дата: {2}", students.Name, students.Group);
        }
    }
}
