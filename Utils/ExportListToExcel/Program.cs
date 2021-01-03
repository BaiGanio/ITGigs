using Common;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExportListToExcel
{
    public class ExternalIds
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UserExport
    {
        public string UserId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }
        public string SubscriptionId { get;  set; }
        public string PropertyId { get;  set; }
        public int UserType { get;  set; }
        public string EnergyType { get;  set; }
        public DateTime? SupplyStartDate { get;  set; }
        public DateTime? SupplyEndDate { get;  set; }

        public int IndustryProvider { get;  set; }
        public string Journey { get;  set; }

        public List<ExternalIds> ExtIds { get; set; }
        public string MaloId { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Step1();
            //Step2();

            //Step3();
        }

        private static void Step3()
        {
            try
            {

                string file = @"C:\Users\lkiko\Desktop\4hundred\local-files\users-21-Oct-20.json";
                string json = "";
                using (StreamReader r = new StreamReader(file))
                {
                    json = r.ReadToEnd();
                }
                dynamic dynJson = JsonConvert.DeserializeObject(json);

                string file2 = @"C:\Users\lkiko\Desktop\4hundred\unsorted\4hundred-missing-malo-updated.json";
                string json2 = "";
                using (StreamReader r = new StreamReader(file2))
                {
                    json2 = r.ReadToEnd();
                }

                List<UserExport> exports = JsonConvert.DeserializeObject<List<UserExport>>(json2);

                List<dynamic> sht = new List<dynamic>();

                int counter = 0;
                int total = 0;
                foreach (var user in dynJson)
                {
                    bool found = false;
                    foreach (var prop in user.Properties)
                    {
                        foreach (var subscr in prop.Subscriptions)
                        {
                            try
                            {
                                if (string.IsNullOrEmpty(Convert.ToString(subscr.MaloId))
                            && (Convert.ToString(user.UserType) == "4" || Convert.ToString(user.UserType) == "5")
                            && (user.Journey != null && JsonConvert.DeserializeObject(Convert.ToString(user.Journey)).Step == "Sit back and relax")
                            && (Convert.ToString(user.IndustryProvider) == "1")
                            )
                                {
                                    foreach (var item in exports)
                                    {
                                        if (item.SubscriptionId == Convert.ToString(subscr.Id.id))
                                        {
                                            found = true;
                                            subscr.MaloId = item.MaloId;
                                            counter++;
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {

                                throw;
                            }
                        }
                    }

                    if (found)
                    {
                        total++;
                        sht.Add(user);
                    }

                }

                var jsonstr = JsonConvert.SerializeObject(sht.ToArray(), Formatting.Indented);

                //write string to file
                File.WriteAllText(@"C:\Users\lkiko\Desktop\4hundred\unsorted\4hundred-missing-malo-4-update.json", jsonstr);
                Console.WriteLine(counter);
                Console.WriteLine(total);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Step2()
        {
            string file = @"C:\Users\lkiko\Desktop\4hundred\unsorted\4hundred-missing-malo-updated.json";
            string json = "";
            using (StreamReader r = new StreamReader(file))
            {
                json = r.ReadToEnd();
            }

            List<UserExport> exports = JsonConvert.DeserializeObject<List<UserExport>>(json);

            FileExporter.SaveByteArrayAsExcelFile(
                @"C:\Users\lkiko\Desktop\4hundred\unsorted\Exported_4hundred_updated_MaloId.xlsx",
                FileExporter.ExportToExcel(exports)
            );
        }

        private static void Step1()
        {
            try
            {
                string file = @"C:\Users\lkiko\Desktop\4hundred\local-files\users-21-Oct-20.json";
                string json = "";
                using (StreamReader r = new StreamReader(file))
                {
                    json = r.ReadToEnd();
                }
                int counter = 0;
                List<UserExport> exports = new List<UserExport>();
                dynamic dynJson = JsonConvert.DeserializeObject(json);
                foreach (var user in dynJson)
                {
                    foreach (var prop in user.Properties)
                    {
                        foreach (var subscr in prop.Subscriptions)
                        {
                            if (string.IsNullOrEmpty(Convert.ToString(subscr.MaloId))
                                && (Convert.ToString(user.UserType) == "4" || Convert.ToString(user.UserType) == "5")
                                && (user.Journey != null && JsonConvert.DeserializeObject(Convert.ToString(user.Journey)).Step == "Sit back and relax")
                                && (Convert.ToString(user.IndustryProvider) == "1")
                                )
                            {
                                counter++;
                                var j = JsonConvert.DeserializeObject<List<ExternalIds>>(Convert.ToString(user.ExternalIds));
                                exports.Add(
                                       new UserExport
                                       {
                                           UserId = user.Id.id,
                                           Firstname = user.FirstName,
                                           Lastname = user.LastName,
                                           Email = user.Email,
                                           UserType = user.UserType,
                                           PropertyId = prop.Id.id,
                                           SubscriptionId = subscr.Id.id,
                                           EnergyType = subscr.EnergyType,
                                           SupplyStartDate = subscr.SupplyStartDate,
                                           SupplyEndDate = subscr.SupplyEndDate,
                                           IndustryProvider = user.IndustryProvider,
                                           Journey = user.Journey == null ? String.Empty : JsonConvert.DeserializeObject(Convert.ToString(user.Journey)).Step,
                                           ExtIds = j
                                       });
                            }
                        }
                    }
                }

                FileExporter.SaveByteArrayAsExcelFile(
                    @"C:\Users\lkiko\Desktop\4hundred\unsorted\Exported_4hundred_new.xlsx",
                    FileExporter.ExportToExcel(exports)
                );

                json = JsonConvert.SerializeObject(exports.ToArray(), Formatting.Indented);

                //write string to file
                File.WriteAllText(@"C:\Users\lkiko\Desktop\4hundred\unsorted\4hundred-missing-malo-new.json", json);
                Console.WriteLine(counter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
