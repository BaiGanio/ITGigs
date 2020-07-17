using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExportListToExcel
{
    public class UserExport
    {
        public string UserId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        //    List<Meter> meters = null;
        //    List<User> users = null;
            try
            {
                string file1 = @"C:\builds\meters.txt";
                string file = @"C:\builds\users.txt";
                using (StreamReader r = new StreamReader(file))
                {
                    string json = r.ReadToEnd();
                    //users = JsonConvert.DeserializeObject<List<User>>(json);
                }
                using (StreamReader r = new StreamReader(file1))
                {
                    string json = r.ReadToEnd();
                    //meters = JsonConvert.DeserializeObject<List<Meter>>(json);
                }
                //if (meters.Any())
                //{
                //    meters = meters.
                //        Where(m => m.EnergyType == EnergyType.Gas
                //                        && m.SubmittedReads.Any(r => r.ReadValue > 0))
                //        .ToList();
                //    //meters = meters.
                //    //   Where(m => m.SubscriptionId == null)
                //    //   .ToList();
                //}
                List<UserExport> exports = new List<UserExport>();
                //foreach (var user in users)
                //{
                //    foreach (var prop in user.Properties)
                //    {
                //        foreach (var subscr in prop.Subscriptions)
                //        {
                //            foreach (var meter in meters)
                //            {
                //                if (meter.SubscriptionId == subscr.Id)
                //                {
                //                    exports.Add(
                //                    new UserExport
                //                    {
                //                        UserId = user.Id.ToString(),
                //                        Firstname = user.FirstName,
                //                        Lastname = user.LastName,
                //                        Email = user.Email,
                //                        UserType = user.UserType,
                //                        PropertyId = prop.Id.ToString(),
                //                        SubscriptionId = subscr.Id.ToString(),
                //                        EnergyType = subscr.EnergyType,
                //                        MeterId = meter.Id.ToString()
                //                    });
                //                }
                //            }
                //        }
                //    }
                //}




                using (ExcelPackage excel = new ExcelPackage())
                {
                    var headerRow = new List<string[]>()
                      {
                        new string[]
                        {
                            "UserID",
                            "First Name",
                            "Last Name",
                            "Email",
                            "UserType",
                            "PropertyId",
                            "SubscriptionId",
                            "EnergyType",
                            "MeterId"
                        }
                      };

                    // Determine the header range (e.g. A1:D1)
                    string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";

                    // Target a worksheet
                    excel.Workbook.Worksheets.Add("negative_cubicValue");
                    var worksheet = excel.Workbook.Worksheets["negative_cubicValue"];

                    // Popular header row data
                    worksheet.Cells[headerRange].LoadFromArrays(headerRow);

                    int row = 2;
                    foreach (var item in exports)
                    {

                        int col = 1;
                        worksheet.Cells[row, col].Value = item.UserId.ToString();
                        col++;
                        worksheet.Cells[row, col].Value = item.Firstname ?? "--";
                        col++;
                        worksheet.Cells[row, col].Value = item.Lastname ?? "--";
                        col++;
                        worksheet.Cells[row, col].Value = item.Email ?? "--";

                        row++;
                    }


                    string filename = @"C:\builds\Exported_4hundred_Users.xlsx";
                    FileInfo excelFile = new FileInfo(filename);
                    excel.SaveAs(excelFile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
