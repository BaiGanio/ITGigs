
using Nancy.Json;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CSV2JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Workbook workbook = new Workbook();


            //workbook.LoadFromFile(@"C:\Users\lkiko\Downloads\Trustpilot30.11.20.xlsx");


            //Worksheet sheet = workbook.Worksheets[0];


            //sheet.SaveToFile(@"C:\Users\lkiko\Downloads\Trustpilot30.11.20.csv", ",", Encoding.UTF8);
            Work1();
        }

        private static void Work1()
        {
            FileStream fileStream;
            StreamReader streamReader;
            CSV2JSON(out fileStream, out streamReader);
        }

        private static void CSV2JSON(out FileStream fileStream, out StreamReader streamReader)
        {
            string path = @"C: \Users\lkiko\Downloads\Trustpilot30.11.20.csv";
            string textFilePath = path;
            const Int32 BufferSize = 128;
            fileStream = null; // File.OpenRead(textFilePath);
            streamReader = null; // new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);
         //   String line;
            int counter = 0;
            Dictionary<string, string> jsonRow = new Dictionary<string, string>();
            var lns = new List<string>();



            foreach (string line1 in File.ReadLines(@"C:\Users\lkiko\Desktop\4hundred\unsorted\Trustpilot30.11.20.txt"))
            {
                if (counter != 0)
                {
                    string[] parts = line1.Split(',');
                    string str = $"{parts[0]},;{parts[1]},;{parts[2]}";
                    lns.Add(str);
                }
                counter++;
            }

            System.IO.File.WriteAllLines(@"C:\Users\lkiko\Desktop\4hundred\unsorted\Trustpilot-reworked30.11.20.txt", lns.ToArray());
            //var json = new JavaScriptSerializer().Serialize(jsonRow);
            //string path_ = @"C:\Users\lkiko\Desktop\4hundred\Unsorted\aktif-all-14-jan-2020.json";
            //File.WriteAllText(path_, json);
        }
    }
}
