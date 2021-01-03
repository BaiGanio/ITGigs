using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StuffsTheyDontTeachYouAtSchool
{
    class Exp
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Ref { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\lkiko\Desktop\4hundred\unsorted\new3.txt");
            string[] lines1 = System.IO.File.ReadAllLines(@"C:\Users\lkiko\Desktop\4hundred\unsorted\new4.txt");
            var counter = 0;
            // Display the file contents by using a foreach loop.
            List<string> emails = new List<string>();
            List<string> names = new List<string>();
            List<Exp> exp = new List<Exp>();
            var exp1 = new Exp();
            foreach (string line in lines)
            {
                if (counter % 2== 0)
                {
                    exp1.Name = line.Trim();
                }
                else
                {
                    exp1.Email = line.Trim();
                    exp.Add(exp1);
                    exp1 = new Exp();
                }
                // Use a tab to indent each line of the file.
                counter++;
            }
            Console.WriteLine(exp.Count);
            //string json = JsonConvert.SerializeObject(exp, Formatting.Indented);
            //Console.WriteLine(json);

            counter = 0;
            var expo = exp.ToArray();
            foreach (string line1 in lines1)
            {
                expo[counter].Ref = line1; 
                counter++;
            }

            var jj = expo.ToList();
            Console.WriteLine(jj.Count);
            string json = JsonConvert.SerializeObject(jj, Formatting.Indented);
            Console.WriteLine(json);

            //using (StreamWriter file = File.CreateText(@"D:\path.txt"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    //serialize object directly into file stream
            //    serializer.Serialize(file, _data);
            //}
            FileExporter.SaveByteArrayAsExcelFile(
                @"C:\Users\lkiko\Desktop\4hundred\unsorted\flo-trustpilot1.xlsx"
                , FileExporter.ExportToExcel(jj));
        }
    }
}
