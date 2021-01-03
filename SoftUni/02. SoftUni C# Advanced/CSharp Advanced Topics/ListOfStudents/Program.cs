using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            string path2File = @"C:\Users\Lyuben Kikov\Desktop\CSharp Advanced Topics\animals.txt";
            string path2File1 = @"C:\Users\Lyuben Kikov\Desktop\CSharp Advanced Topics\students.txt";

            try
            {
                List<string> students = ReadStudentsFromFile(path2File1);

                foreach (var student in students)
                {
                    string[] currentValues = student.Split(' ');
                    if (currentValues[1] == "6")
                    {
                        Console.WriteLine($"Student with mark: {currentValues[1]} have name {currentValues[0]}");
                    }
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static List<string> ReadStudentsFromFile(string file)
        {
            List<string> students = new List<string>();
           
            StreamReader reader = new StreamReader(file);

            string line = reader.ReadLine();

            while (line != null)
            {
                students.Add(line);
                //Console.WriteLine(line);
                line = reader.ReadLine();
            }
            return students;
        }

    }
}
