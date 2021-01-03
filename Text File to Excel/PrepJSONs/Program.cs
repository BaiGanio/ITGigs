using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web.Script.Serialization;

namespace PrepJSONs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\PROJECTS\old projects\Text File to Excel\new2.txt";
            string json = string.Empty;
            string fullName = string.Empty;

            using (StreamReader reader = new StreamReader(path))
            {
                string[] newLine = reader.ReadLine().Split(';');
                for (int i = 0; i < newLine.Length; i++)
                {
                    newLine[i] = newLine[i].Replace('\"', ' ').Trim();
                }


                AktifConsumer ac = new AktifConsumer();
                ac.CLIENT_ID = "";
                ac.CONSUMER_ID = newLine[12];
                ac.CONSUMER_NO = ConvertCustomIdToInt(newLine[12]).ToString();
                ac.COMMODITY = newLine[7];
                ac.NAME1 = newLine[0];
                ac.NAME2 = newLine[1];
                ac.CITY = newLine[4];
                ac.ZIPCODE = newLine[3];
                ac.STREET = newLine[5];
                ac.STREETNO = newLine[6];
                ac.SERIALID = newLine[10];
                ac.CARRIER_ID = newLine[9];
                ac.CONSUMPTION = newLine[8];
                ac.SUPPLYSTART = "ASAP";
                ac.SUPPLYEND = null;
                ac.PROFILE = "H1";
                ac.SUPPLY_REASON = "2";
                ac.PRODUCT = newLine[7] == "E" ? "E" : "G";
                ac.DURATION = "3";
                ac.DENOUNCE = "2";
                ac.DENOUNCE_TARGET = "2";
                ac.CHANGE_DATE = DateTime.Now.ToString();
                json = new JavaScriptSerializer().Serialize(ac);
                fullName = newLine[0] + " " + newLine[1];
            }
            Console.WriteLine(json);
            path = @"D:\PROJECTS\old projects\Text File to Excel\" + fullName + ".txt";

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(json);
            }

        }




        public static int ConvertCustomIdToInt(string id)
        {
            MD5 md5Hasher = MD5.Create();
            var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(id));
            int ivalue = BitConverter.ToInt32(hashed, 0);
            return Math.Abs(ivalue);
        }
    }
}
