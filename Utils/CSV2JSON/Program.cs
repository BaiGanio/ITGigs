
using ChoETL;
using Microsoft.VisualBasic.FileIO;
using Nancy.Json;
using Newtonsoft.Json;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV2JSON
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string CSVpath = @"C:\Users\lkiko\Downloads\splitcsv-2e2ee9bf-1d8c-4979-814c-893ae2c0f5f4-results\BasicCompanyDataAsOneFile-2021-02-01-1.csv";
            string analyticsData = await ReadFile(CSVpath);
            Console.WriteLine(analyticsData);
        }

        private static async Task<string> ReadFile(string filePath)
        {
            string payload = "";
            var sb = new StringBuilder();
            try
            {
                if (!string.IsNullOrWhiteSpace(filePath) && File.Exists(filePath) && Path.GetExtension(filePath).Equals(".csv", StringComparison.InvariantCultureIgnoreCase))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines != null && lines.Length > 1)
                    {
                        var headers = GetHeaders(lines.First());
                        //payload = GetPayload(headers, lines.Skip(1));
                        foreach (var line in lines.Skip(1))
                        {
                            //Console.WriteLine(GetPayload(headers, new string[] { line }));


                            //System.IO.File.WriteAllLines(@"C:\Users\lkiko\Desktop\4hundred\unsorted\Trustpilot-reworked30.11.20.txt", lns.ToArray());
                            var json = JsonConvert.SerializeObject(GetPayload(headers, new string[] { line }));
                            json = json.Replace('\\', ' ');
                            string path_ = @"C:\Users\lkiko\Desktop\wtf\res.json";

                            using StreamWriter file = new StreamWriter(path_, append: true);


                     
                            await file.WriteLineAsync(json);
                        }
                    }

                }
              //  Console.WriteLine(sb.ToString());
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return payload;
        }

        private static IEnumerable<string> GetHeaders(string data)
        {
            IEnumerable<string> headers = null;

            if (!string.IsNullOrWhiteSpace(data) && data.Contains(','))
            {
                headers = GetFields(data).Select(x => x.Replace(" ", ""));
            }
            return headers;
        }

        private static string GetPayload(IEnumerable<string> headers, IEnumerable<string> fields)
        {
            string jsonObject = "";
            try
            {
                var dictionaryList = fields.Select(x => GetField(headers, x));
                jsonObject = JsonConvert.SerializeObject(dictionaryList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return jsonObject;
        }

        private static Dictionary<string, string> GetField(IEnumerable<string> headers, string fields)
        {
            Dictionary<string, string> dictionary = null;

            if (!string.IsNullOrWhiteSpace(fields))
            {
                var columns = GetFields(fields);

                if (columns != null && headers != null && columns.Count() == headers.Count())
                {
                    dictionary = headers.Zip(columns, (x, y) => new { x, y }).ToDictionary(item => item.x, item => item.y);
                }
            }
            return dictionary;
        }

        public static IEnumerable<string> GetFields(string line)
        {
            IEnumerable<string> fields = null;
            using (TextReader reader = new StringReader(line))
            {
                using (TextFieldParser parser = new TextFieldParser(reader))
                {
                    parser.TextFieldType = FieldType.Delimited; parser.SetDelimiters(","); fields = parser.ReadFields();
                }
            }
            return fields;
        }

    //static void Main(string[] args)
    //{
    //    //Workbook workbook = new Workbook();


    //    //workbook.LoadFromFile(@"C:\Users\lkiko\Downloads\Trustpilot30.11.20.xlsx");


    //    //Worksheet sheet = workbook.Worksheets[0];


    //    //sheet.SaveToFile(@"C:\Users\lkiko\Downloads\Trustpilot30.11.20.csv", ",", Encoding.UTF8);
    //    //Work1();

    //    //string csv = @"C:\Users\lkiko\Downloads\BasicCompanyData-2021-02-01-part6_6\BasicCompanyData-2021-02-01-part6_6.csv";
    //    //System.IO.StreamReader file =
    //    //    new System.IO.StreamReader(csv);
    //    //var sb1 = new StringBuilder();
    //    //string line;
    //    //while ((line = file.ReadLine()) != null)
    //    //{
    //    //    sb1.AppendLine(line);
    //    //}
    //    //Console.WriteLine("Start.....");
    //    //Stopwatch stopwatch = Stopwatch.StartNew();
    //    //stopwatch.Stop();
    //    //Console.WriteLine(stopwatch.ElapsedMilliseconds);
    //    //StringBuilder sb = new StringBuilder();
    //    //using (var p = ChoCSVReader.LoadText(sb1.ToString())
    //    //    .WithFirstLineHeader()
    //    //    )
    //    //{
    //    //    using (var w = new ChoJSONWriter(sb))
    //    //        w.Write(p);
    //    //}
    //    //stopwatch.Stop();
    //    //Console.WriteLine(stopwatch.ElapsedMilliseconds);
    //    //Console.WriteLine(sb.ToString());

    //    Stopwatch stopwatch = Stopwatch.StartNew();
    //    stopwatch.Stop();
    //    var jj =  ConvertToJSON();
    //    stopwatch.Stop();
    //    Console.WriteLine(jj);
    //}

    public static string ConvertToJSON()
        {
            string json = string.Empty;
            string csv = string.Empty;

            using (StreamReader reader = new StreamReader(@"C:\Users\lkiko\Downloads\BasicCompanyData-2021-02-01-part6_6\BasicCompanyData-2021-02-01-part6_6.csv"))
            {
                csv = reader.ReadToEnd();
            }

            string[] lines = csv.Split(new string[] { "\n" }, System.StringSplitOptions.None);

            if (lines.Length > 1)
            {
                // parse headers
                string[] headers = lines[0].Split(',');

                StringBuilder sbjson = new StringBuilder();
                sbjson.Clear();
                sbjson.Append("[");

                // parse data
                for (int i = 1; i < lines.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lines[i])) continue;
                    if (string.IsNullOrEmpty(lines[i])) continue;

                    sbjson.Append("{");

                    string[] data = lines[i].Split(',');

                    for (int h = 0; h < headers.Length; h++)
                    {
                        sbjson.Append(
                            $"\"{headers[h]}\": \"{data[h]}\"" + (h < headers.Length - 1 ? "," : null)
                        );
                    }

                    sbjson.Append("}" + (i < lines.Length - 1 ? "," : null));
                }

                sbjson.Append("]");

                json = sbjson.ToString();
            }

            return json;
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
