using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace _2Excel.ConsoleClient
{
    internal class SponsorInfo
    {
        public int ID { get; set; }
        public int FirstBAID { get; set; }
    }
    class Startup
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

                var jsonText = @"D:\PROJECTS\Unfinished Projects\Text File to Excel\_2Excel.ConsoleClient\TestFiles\SponsorInfo.txt";
                SponsorInfo[] data = JsonConvert.DeserializeObject<List<SponsorInfo>>(jsonText).ToArray();
               
                Console.WriteLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }
            Console.WriteLine("Work is done!");
        }

        private static DataTable BuildDataTable(string[] data)
        {
            // Expecting Data
            if (data == null || data.Length == 0)
                return new DataTable();

            // Build Schema From First Row of Data
            DataTable table = CreateTable(data[0]);

            // Load Up The Rows
            PopulateTable(data, table);

            return table;
        }

        /*This creates column names. */
        private static DataTable CreateTable(string pipeDelimitedString)
        {
            DataTable data = new DataTable("my-table");
            string[] columns = pipeDelimitedString.Split('|');

            for (int i = 0; i < columns.Length; i++)
            {
                /* Current index is the `column`... so asign a name. */
                if (i == 0)
                {
                    data.Columns.Add("PLZ", typeof(string));
                }
                else if (i == 1)
                {
                    data.Columns.Add("Ort", typeof(string));
                }
                else if (i == 2)
                {
                    data.Columns.Add("GV", typeof(string));
                }
                else if (i == 3)
                {
                    data.Columns.Add("GV Jahrespreis", typeof(string));
                }
                else if (i == 4)
                {
                    data.Columns.Add("4h Monthly cost (€ per month)", typeof(string));
                }
                else if (i == 5)
                {
                    data.Columns.Add("4h unit rate (€ per kWh)", typeof(string));
                }
            }
            return data;
        }

        /* This do the excel file. */
        private static void PopulateTable(string[] data, DataTable table)
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string filePath = Path.Combine(Path.GetDirectoryName(exePath), @"D:\PROJECTS\Unfinished Projects\Text File to Excel\_2Excel.ConsoleClient\TestFiles\SponsorInfo.txt");
            string[] lines = System.IO.File.ReadAllLines(filePath, Encoding.GetEncoding(1252));


            for (int i = 0; i < data.Length; i++)
            {
                string[] columns = data[i].Split('|');
                try
                {
                    string[] rowData = new string[] { lines[i], columns[0], "" };
                    table.LoadDataRow(rowData, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

   
}
