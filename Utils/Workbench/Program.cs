using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Workbench
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = @"C:\Users\lkiko\Desktop\4hundred\unsorted\missing-malo-or-melo-id.json";
            string json = File.ReadAllText(jsonFilePath);
            List<User> basicfiltered = JsonConvert.DeserializeObject<List<User>>(json);

            Console.WriteLine(basicfiltered.Count);

            jsonFilePath = @"C:\Users\lkiko\Desktop\4hundred\local-files\users-15-Sep-20.json";
            json = File.ReadAllText(jsonFilePath);


            List<User> extracted = new List<User>();
            dynamic array = JsonConvert.DeserializeObject(json);

            foreach (var item in array)
            {
                if (item.IndustryProvider == 0)
                {
                    foreach (var prop in item.Properties)
                    {
                        foreach (var subscr in prop.Subscriptions)
                        {
                            foreach (var filteredUser in basicfiltered)
                            {
                                try
                                {
                                    string id = subscr.Id.id;
                                    if (HashUtils.ConvertCustomIdToInt(id).ToString() == filteredUser.ConsumerNo)
                                    {
                                        extracted.Add(
                                                new User()
                                                {
                                                    Email = filteredUser.Email,
                                                    MaloId = filteredUser.MaloId,
                                                    ConsumerNo = filteredUser.ConsumerNo,
                                                    Energy = filteredUser.Energy,
                                                    Status = filteredUser.Status,
                                                    AktifSupplyStart = filteredUser.AktifSupplyStart,
                                                    AktifSupplyEnd = filteredUser.AktifSupplyEnd,
                                                    FHSupplyStart = subscr.SupplyStartDate,
                                                    FHSupplyEnd = subscr.SupplyEndDate,
                                                    MeloId = subscr.MeloId,
                                                    SubscriptionId = subscr.Id.id,
                                                    FHEmail = item.Email,
                                                    FHId = item.Id.id
                                                });

                                        break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    //counter++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(extracted.Count);

            extracted = extracted.Where(x => string.IsNullOrEmpty(x.MeloId) != true).ToList();

            Console.WriteLine(extracted.Count);


            string json1 = JsonConvert.SerializeObject(extracted, Formatting.Indented);
            File.WriteAllText(@"C:\Users\lkiko\Desktop\4hundred\unsorted\newly_filtered\missing-malo-id.json", json1);
            //Console.WriteLine($"Failed: {counter} - {error}");


            File.WriteAllBytes(@"C:\Users\lkiko\Desktop\4hundred\unsorted\newly_filtered\missing-malo-id.xls", FileExporter.ExportToExcel(extracted));


            //DoJob1BasicFiltration();
            //DoJob2Extract4hUsers();
            //DoJob3ExtractData();
            //DoJob4AdditionalFiltration();
        }

        private static void DoJob4AdditionalFiltration()
        {
            string jsonFilePath = @"C:\Users\lkiko\Desktop\4hundred\unsorted\basic-filter-extracted.json";
            string json = File.ReadAllText(jsonFilePath);
            List<User> basicfiltered = JsonConvert.DeserializeObject<List<User>>(json);

            basicfiltered = basicfiltered.Where(x => string.IsNullOrEmpty(x.MeloId) || string.IsNullOrEmpty(x.MaloId)).ToList();
            var basicfiltered1 = basicfiltered.GroupBy(x => x.ConsumerNo).Select(g => g.First()).ToList();
            string json1 = JsonConvert.SerializeObject(basicfiltered1, Formatting.Indented);
            File.WriteAllText(@"C:\Users\lkiko\Desktop\4hundred\unsorted\final-incorrect-distinct.json", json1);
            Console.WriteLine($"Correct: {basicfiltered1.Count}");


            File.WriteAllBytes(@"C:\Users\lkiko\Desktop\4hundred\unsorted\final-incorrect-distinct-aktif-filtered.xls", FileExporter.ExportToExcel(basicfiltered1));
        }

        private static void DoJob2Extract4hUsers()
        {
            string jsonFilePath = @"C:\Users\lkiko\Desktop\4hundred\local-files\users-14-Sep-20.json";
            string json = File.ReadAllText(jsonFilePath);
            dynamic array = JsonConvert.DeserializeObject(json);
            List<User> extracted = new List<User>();
            foreach (var item in array)
            {
                if (item.IndustryProvider == 0)
                {
                    foreach (var prop in item.Properties)
                    {
                        foreach (var subscr in prop.Subscriptions)
                        {
                            extracted.Add(
                                new User()
                                {
                                    Email = item.Email,
                                    SubscriptionId = subscr.Id.id,
                                    FHSupplyStart = subscr.SupplyStartDate,
                                    FHSupplyEnd = subscr.SupplyEndDate,
                                    MeloId = subscr.MeloId
                                });
                        }
                    }
                }
            }

            string jsonD = JsonConvert.SerializeObject(extracted, Formatting.Indented);
            File.WriteAllText(@"C:\Users\lkiko\Desktop\4hundred\unsorted\extracted4h.json", jsonD);
        }

        private static void DoJob3ExtractData()
        {
            string jsonFilePath = @"C:\Users\lkiko\Desktop\4hundred\unsorted\basic-filter.json";
            string json = File.ReadAllText(jsonFilePath);
            List<User> basicfiltered = JsonConvert.DeserializeObject<List<User>>(json);
            jsonFilePath = @"C:\Users\lkiko\Desktop\4hundred\unsorted\extracted4h.json";
            json = File.ReadAllText(jsonFilePath);
            List<User> extracted = JsonConvert.DeserializeObject<List<User>>(json);
            int counter = 0;
            List<User> updated = new List<User>();
            var grouped = basicfiltered.GroupBy(item => item.Email).ToList();

            string error = "";
            foreach (var filteredUser in basicfiltered)
            {
                bool found = false;
                var array = extracted.Where(x => x.Email == filteredUser.Email).ToList();

                foreach (var user in array)
                {
                    try
                    {
                        if (HashUtils.ConvertCustomIdToInt(user.SubscriptionId) == Convert.ToInt32(filteredUser.ConsumerNo))
                        {
                            found = true;
                            updated.Add(
                                new User()
                                {
                                    Email = filteredUser.Email,
                                    MaloId = filteredUser.MaloId,
                                    ConsumerNo = filteredUser.ConsumerNo,
                                    Energy = filteredUser.Energy,
                                    Status = filteredUser.Status,
                                    AktifSupplyStart = filteredUser.AktifSupplyStart,
                                    AktifSupplyEnd = filteredUser.AktifSupplyEnd,
                                    FHSupplyStart = user.FHSupplyStart,
                                    FHSupplyEnd = user.FHSupplyEnd,
                                    MeloId = user.MeloId,
                                    SubscriptionId = user.SubscriptionId,
                                });

                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        error = ex.Message;
                        counter++;
                    }
                }
                if (!found)
                {
                    updated.Add(filteredUser);
                }
            }

            string json1 = JsonConvert.SerializeObject(updated, Formatting.Indented);
            File.WriteAllText(@"C:\Users\lkiko\Desktop\4hundred\unsorted\basic-filter-extracted.json", json1);
            Console.WriteLine($"Failed: {counter} - {error}");


            File.WriteAllBytes(@"C:\Users\lkiko\Desktop\4hundred\unsorted\aktif-filtered.xls", FileExporter.ExportToExcel(updated));
        }

        private static void DoJob1BasicFiltration()
        {
            int counter = 0;
            var listA = new List<User>();
            var updated = new List<User>();
            using (var reader = new StreamReader(@"C:\Users\lkiko\Desktop\4hundred\unsorted\csv-aktif.csv"))
            {
                Console.WriteLine("reading csv");
                //List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (counter == 0)
                    {
                        counter++;
                        continue;
                    }

                    var values = line.Split(',');
                    var dt = DateTime.Parse(values[9].Replace('.', '-'));
                    listA.Add(new User()
                    {
                        Email = values[0],
                        MaloId = values[20],
                        ConsumerNo = values[24],
                        Energy = values[25],
                        Status = values[8],
                        AktifSupplyStart = values[9],
                        AktifSupplyEnd = values[10]
                    });
                }
            }

            var grouped = listA.Where(x => x.Status == "x")
                .GroupBy(item => item.Email)
                .ToList();

            foreach (var key in grouped)
            {
                var groupedByConsumerNo = key.GroupBy(k => k.ConsumerNo).Distinct().ToList();
                foreach (var consumerNo in groupedByConsumerNo)
                {
                    foreach (var consumerNoKey in consumerNo)
                    {
                        updated.Add(new User()
                        {
                            Email = consumerNoKey.Email,
                            MaloId = consumerNoKey.MaloId,
                            ConsumerNo = consumerNoKey.ConsumerNo,
                            Energy = consumerNoKey.Energy,
                            Status = consumerNoKey.Status,
                            AktifSupplyStart = consumerNoKey.AktifSupplyStart,
                            AktifSupplyEnd = consumerNoKey.AktifSupplyEnd
                        });
                    }
                }
            }

            string json = JsonConvert.SerializeObject(updated, Formatting.Indented);
            File.WriteAllText(@"C:\Users\lkiko\Desktop\4hundred\unsorted\basic-filter.json", json);
        }
    }

    class User
    {
        public string Email { get; set; }
        public string MaloId { get; set; }
        public string MeloId { get; set; }
        public string ConsumerNo { get; set; }
        public string SubscriptionId { get; set; }
        public string Energy { get; set; }
        public string Status { get; set; }
        public string UserType { get; set; }
        public string AktifSupplyStart { get; set; }
        public string AktifSupplyEnd { get; set; }
        public string FHSupplyStart { get; set; }
        public string FHSupplyEnd { get; set; }
        public string FHId { get; set; }
        public string FHEmail { get; set; }
    }
}
