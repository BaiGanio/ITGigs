using Nancy.Json;
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
            string path = @"C:\Users\lkiko\Desktop\4hundred\Unsorted\aktif-all-14-jan-2020.csv";
            string textFilePath = path;
            const Int32 BufferSize = 128;

            using var fileStream = File.OpenRead(textFilePath);
            using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);
            String line;
            Dictionary<string, string> jsonRow = new Dictionary<string, string>();

            while ((line = streamReader.ReadLine()) != null)
            {

                string[] parts = line.Split(',');

                string key_ = parts[0];
                string value = parts[1];


                if (!jsonRow.Keys.Contains(key_))
                {
                    jsonRow.Add(key_, value);
                }

            }
            var json = new JavaScriptSerializer().Serialize(jsonRow);
            string path_ = @"C:\Users\lkiko\Desktop\4hundred\Unsorted\aktif-all-14-jan-2020.json";
            File.WriteAllText(path_, json);
        }
    }
}
