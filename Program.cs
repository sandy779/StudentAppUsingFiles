using System;
using System.Collections.Generic;
using System.IO;
namespace FilesDemo
{

    class Studentapp
    {
        public Studentapp()
        {

        }
        public void WriteData()
        {

            int n;
            FileStream fs = new FileStream(@"E:\example\student.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("How many records you want to add");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter id");
                string id = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter marks");
                object marks = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                object Name = Convert.ToString(Console.ReadLine());
                sw.Write("\n ID :" + id);
                sw.Write("\n Marks:" + marks);
                sw.Write("\n Name:" + Name);

            }

            Console.WriteLine("Records added Successfully...");


            sw.Flush();

            sw.Close();

        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Studentapp app = new Studentapp();
            app.WriteData();

        }
    }
}