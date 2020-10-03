using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Address { get; set; }
    }
    class SerializationDemo
    {
        static void Main(string[] args)
        {
            Serialize();
            Console.WriteLine("Binary Serialization Sucessfull!!!");

        }

        private static void Serialize()
        {
            Student s = new Student { Name = "Sohel", RollNo = 2491, Address = "Mysore" };
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("Demo.bin", FileMode.OpenOrCreate, FileAccess.Write);
            bf.Serialize(fs, s);
            fs.Close();
        }
    }
}