using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Write2File
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example #1: Write an array of strings to a file.
            // StringArrayToFile();
            // Example #2: Write dictionary as json to a file.
            //DictionaryToJSON();
            string str =
         "{\"Properties\":[{\"Id\":{\"id\":\"beb33aeb-0b5e-439b-b0b7-77941e9fc82e\"},\"Subscriptions\":[{\"Id\":{\"id\":\"68c652bc-3a27-4caa-8f9a-6c394a182c8d\"},\"EnergyType\":\"Gas\",\"SupplyStartDate\":\"2019-01-01T00:00:00\",\"AnnualConsumption\":21148,\"NighttimeAnnualConsumption\":0,\"Quotes\":[{\"TotalBillEstimateAnnual\":957.816,\"TotalSavingAnnual\":333.25000000000006,\"StandingChargeMonthly\":10.6,\"UnitRatePerKWh\":0.0424,\"UsageAnnual\":19590,\"MoneyBreakdown\":{\"Energiepreis\":43.5,\"Netzkosten\":22.6,\"Konzessionsabgabe\":0.5,\"Gassteuer\":10.0,\"MWST\":16.0,\"Grundgebuehr\":7.5},\"EnergyType\":\"Gas\",\"ValidForYear\":2018,\"NighttimeUnitRatePerKWh\":0.0,\"NighttimeUsageAnnual\":0,\"NetworkOperatorNumber\":\"9870009000009\",\"GeneratedOn\":\"0001-01-01T00:00:00\",\"ValidFrom\":\"2018-01-01T00:00:00\",\"ValidTo\":\"2020-01-10T23:59:59+00:00\",\"QuoteType\":\"Extended\"},{\"Id\":{\"id\":\"c3b8d4e0-6849-4567-9082-f066cfc8372a\"},\"TotalBillEstimateAnnual\":5490.043,\"TotalSavingAnnual\":465.233,\"StandingChargeMonthly\":12.818,\"UnitRatePerKWh\":0.2523,\"UsageAnnual\":21148,\"MoneyBreakdown\":{\"Energiepreis\":25.0,\"Netzkosten\":20.4,\"Konzessionsabgabe\":6.1,\"EEGUmlage\":26.0,\"AndereUmlage\":3.9,\"Stromsteuer\":7.9,\"MWST\":17.3,\"Grundgebuehr\":1.5},\"EnergyType\":\"Electricity\",\"ValidForYear\":2020,\"NighttimeUnitRatePerKWh\":0.0,\"NighttimeUsageAnnual\":0,\"NetworkOperatorNumber\":\"9907787000009\",\"GeneratedOn\":\"2019-11-29T15:07:39.4904235+00:00\",\"ValidFrom\":\"2020-01-11T00:00:00+00:00\",\"ValidTo\":\"2021-01-10T23:59:59+00:00\",\"QuoteType\":\"Extended\"}],\"FirstName\":\"Anke\",\"LastName\":\"Günther\",\"OldSupplierId\":\"9800049500008\",\"CancelledPreviousContract\":false,\"SwitchAsap\":false,\"UsageConStatus\":\"x\",\"SupplyConStatus\":\"x\",\"MeasuredLevel\":\"\",\"ConnectionLevel\":\"\",\"MeloId\":\"DE700090308260000201396013000G001\",\"IsDeactivated\":false,\"LeadSourceType\":\"NotSpecified\"},{\"Id\":{\"id\":\"0311391d-94d7-476f-b74e-5f4b16cb1d21\"},\"EnergyType\":\"Electricity\",\"SupplyStartDate\":\"2019-02-01T00:00:00\",\"AnnualConsumption\":2052,\"NighttimeAnnualConsumption\":0,\"Quotes\":[{\"TotalBillEstimateAnnual\":1337.9088000000002,\"TotalSavingAnnual\":144.5961999999999,\"StandingChargeMonthly\":6.2,\"UnitRatePerKWh\":0.2284,\"UsageAnnual\":5532,\"MoneyBreakdown\":{\"Energiepreis\":20.8,\"Netzkosten\":18.2,\"Konzessionsabgabe\":6.1,\"EEGUmlage\":26.2,\"AndereUmlage\":2.9,\"Stromsteuer\":7.9,\"MWST\":16.7,\"Grundgebuehr\":5.6},\"EnergyType\":\"Electricity\",\"ValidForYear\":2018,\"NighttimeUnitRatePerKWh\":0.0,\"NighttimeUsageAnnual\":0,\"NetworkOperatorNumber\":\"9900786000004\",\"GeneratedOn\":\"0001-01-01T00:00:00\",\"ValidFrom\":\"2018-01-01T00:00:00\",\"ValidTo\":\"2020-01-31T23:59:59+00:00\",\"QuoteType\":\"Extended\"},{\"Id\":{\"id\":\"3fb5b7b7-ea98-4f5c-8ea1-3c37149d4269\"},\"TotalBillEstimateAnnual\":671.107,\"TotalSavingAnnual\":-31.855,\"StandingChargeMonthly\":14.26,\"UnitRatePerKWh\":0.03459,\"UsageAnnual\":2052,\"MoneyBreakdown\":{\"Energiepreis\":19.9,\"Netzkosten\":22.7,\"Konzessionsabgabe\":4.9,\"EEGUmlage\":20.7,\"AndereUmlage\":3.1,\"Stromsteuer\":6.3,\"MWST\":17.0,\"Grundgebuehr\":12.0},\"EnergyType\":\"Electricity\",\"ValidForYear\":2020,\"NighttimeUnitRatePerKWh\":0.0,\"NighttimeUsageAnnual\":0,\"NetworkOperatorNumber\":\"9907787000009\",\"GeneratedOn\":\"2019-12-20T16:20:21.6012037+00:00\",\"ValidFrom\":\"2020-02-01T00:00:00+00:00\",\"ValidTo\":\"2021-01-31T23:59:59+00:00\",\"QuoteType\":\"Extended\"}],\"FirstName\":\"Anke\",\"LastName\":\"Günther\",\"OldSupplierId\":\"9903214000009\",\"OldSupplierName\":\"eprimo GmbH\",\"CancelledPreviousContract\":false,\"SwitchAsap\":false,\"UsageConStatus\":\"x\",\"SupplyConStatus\":\"x\",\"MeasuredLevel\":\"\",\"ConnectionLevel\":\"\",\"MeloId\":\"\",\"IsDeactivated\":false,\"ExternalIds\":[{\"Id\":2128835253,\"Name\":\"Aktif\"}],\"LeadSourceType\":\"NotSpecified\"}],\"Addresses\":[{\"PostCode\":\"30826\",\"HouseNumber\":\"13\",\"Street\":\"Brinkwiesen\",\"Town\":\"Garbsen\",\"Country\":\"Germany\",\"Type\":1,\"Gender\":\"NotSpecified\"},{\"PostCode\":\"30826\",\"HouseNumber\":\"13\",\"Street\":\"Brinkwiesen\",\"Town\":\"Garbsen\",\"Country\":\"Germany\",\"Type\":2,\"Gender\":\"NotSpecified\"}],\"Journey\":{\"Step\":\"Sit back and relax\",\"JourneyStatus\":\"Journey Complete\"},\"IsDeactivated\":false}],\"Meters\":[],\"Id\":{\"id\":\"9c2268d6-fee4-4ce2-831d-495def0a25db\"},\"FirstName\":\"Anke\",\"LastName\":\"Günther\",\"Gender\":\"Female\",\"UserType\":4,\"Title\":\"No title\",\"Email\":\"meerschweinchenblau@icloud.com\",\"MobilePhoneNumber\":\"\",\"HomeAddress\":{\"PostCode\":\"30826\",\"HouseNumber\":\"13\",\"Street\":\"Brinkwiesen\",\"Town\":\"Garbsen\",\"Country\":\"Germany\",\"Type\":0,\"Gender\":\"NotSpecified\"},\"PreferredLanguage\":\"German\",\"Password\":\"m0atnActPRy6maJb5XKtKtEyX7+Z1VqKd54U1xjt53I6nexV\",\"PartialValidationCode\":\"9d38e8ad-146a-4a36-8340-f0b2610adb1f\",\"IsValidated\":true,\"Journey\":{\"Step\":\"Sit back and relax\",\"JourneyStatus\":\"Journey Complete\",\"StartDate\":\"2018-12-10T21:57:28.2339094+00:00\"},\"ReferralTrack\":{\"ReferralCode\":\"Anke3\",\"ReferralsClicks\":0,\"RegisteredReferralUserIds\":[]},\"RegistrationIP\":\"\",\"RegistrationDisclaimer\":\"\",\"CreatedOn\":\"2018-11-22T13:59:07.1029724+00:00\",\"CoolingOffPeriodEnd\":\"2018-12-06T13:59:07.1453109+00:00\",\"ModifiedOn\":\"2019-12-20T16:20:21.6169527+00:00\",\"HasActiveNewsletterSubscription\":false,\"NotificationsTypes\":[1,4,2],\"LeadSource\":\"Verivox\",\"EmailValidationDate\":\"2018-11-22T13:59:07.1453109+00:00\",\"ChangingHouse\":false,\"IndustryProvider\":0}"


            ;

            str = str.Replace('\\', ' ');
            System.IO.File.WriteAllText(@"C:\Users\lkiko\Desktop\fuckedup.json", str);
            Console.WriteLine(str);


        }

        private static void DictionaryToJSON()
        {
            //Dictionary<string, object> dictss =
            //   new Dictionary<string, object>()
            //   {
            //        {"User", new List<string>(){"Mr.Joshua", "mo" } },
            //        {"Pass", "4324"},
            //   };

            //string jsonString = (new JavaScriptSerializer()).Serialize((object)dictss);
            //Console.WriteLine(jsonString);

            string courseId = Guid.NewGuid().ToString();
            string createdBy = Guid.NewGuid().ToString();
            List<Homework> homeworks =
               new List<Homework>()
               {
                   new Homework()
                   {
                       Id = Guid.NewGuid().ToString(), Week = "5", CourseId = courseId, CreatedBy = createdBy,
                       Tasks = new List<HomeworkTask>(){ new HomeworkTask() { Id = Guid.NewGuid().ToString(), Proposition = "Sum 2+2", DownloadLink = "https://stackoverflow.com/questions/22536818" } }
                   },
                   new Homework()
                   {
                       Id = Guid.NewGuid().ToString(), Week = "9", CourseId = courseId, CreatedBy = createdBy,
                       Tasks = new List<HomeworkTask>(){ new HomeworkTask() { Id = Guid.NewGuid().ToString(), Proposition = "Divide 9/3", DownloadLink = "https://stackoverflow.com/questions/22536818" } }
                   },
                   new Homework()
                   {
                       Id = Guid.NewGuid().ToString(), Week = "2", CourseId = courseId, CreatedBy = createdBy,
                       Tasks = new List<HomeworkTask>(){ new HomeworkTask() { Id = Guid.NewGuid().ToString(), Proposition = "Multiply 9*8", DownloadLink = "https://stackoverflow.com/questions/22536818" } }
                   },
                   new Homework()
                   {
                       Id = Guid.NewGuid().ToString(), Week = "1", CourseId = courseId, CreatedBy = createdBy,
                        Tasks = new List<HomeworkTask>()
                        {
                            new HomeworkTask()
                            {
                                Id = Guid.NewGuid().ToString(), Proposition = "Multiply 9*8", Name= "AgeAfterTenYears",  DownloadLink = "https://stackoverflow.com/questions/22536818",
                                TargetMethods = new List<string>(){"AgeCalculator"}
                            },
                            new HomeworkTask()
                            {
                                Id = Guid.NewGuid().ToString(), Proposition = "Write program which prints 'Hey there!' to the console.", Name= "HiProgram",  DownloadLink = "https://stackoverflow.com/questions/22536818"
                            },
                            new HomeworkTask()
                            {
                                Id = Guid.NewGuid().ToString(), Proposition = "Write program which creates unique number in diapazon 100 - 1000.", Name= "MyUniqueNumber",  DownloadLink = "https://stackoverflow.com/questions/22536818"
                            }
                        }
                    }
               };

            string json = JsonConvert.SerializeObject(homeworks);
            System.IO.File.WriteAllText(@"C:\Users\lkiko\Desktop\fk\homeworks.json", json);
        }

        private static void StringArrayToFile()
        {
            // Create a string array that consists of three lines.
            string[] lines = new string[500]; //{ "First line", "Second line", "Third line" };
                                              // WriteAllLines creates a file, writes a collection of strings to the


            //for (int i = 0; i < 200; i++)
            //{
            //    string email = $"lyuben.kikov{i}@4hundred.com"; 
            //    lines[i] = $"23335595;21.09.2018;4hundred Ökostrom;Strom;Privat;Online;;;;1049060013668217;E.ON Energie Deutschland GmbH;9903323000007;242091854456;1650;;;;;;;Herr;;Uwe;Müller;{email};;06.03.1966;Königsberger Str.;14b;29690;Schwarmstedt;;;;;;;;;;Lastschrift;L;;DE09251523750008157224;;;;;;5,92;7,05;20,71;24,38;;0;0;0;;;0;12 Monate;;;;;";
            //}
            //// and then closes the file.  You do NOT need to call Flush() or Close().
            //System.IO.File.WriteAllLines(@"C:\buildsWriteLines.txt", lines);

            using (StreamWriter writetext = new StreamWriter(@"C:\builds\WriteLines.txt"))
            {
                for (int i = 0; i < 500; i++)
                {
                    string email = $"lk{i}@4hundred.com";
                    string line = $"23335595;21.09.2018;4hundred Ökostrom;Strom;Privat;Online;;;;1049060013668217;E.ON Energie Deutschland GmbH;9903323000007;242091854456;1650;;;;;;;Herr;;Uwe;Müller;{email};;06.03.1966;Königsberger Str.;14b;29690;Schwarmstedt;;;;;;;;;;Lastschrift;L;;DE09251523750008157224;;;;;;5,92;7,05;20,71;24,38;;0;0;0;;;0;12 Monate;;;;;";
                    writetext.WriteLine(line);
                }

            }
        }

        class Homework
        {
            public string Id { get; set; }
            public string Week { get; set; }
            public string CourseId { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public List<HomeworkTask> Tasks { get; set; }
        }

        class HomeworkTask
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Proposition { get; set; }
            public string RawHtml { get; set; }
            public string HelpfulUrls { get; set; }
            public string DownloadLink { get; set; }
            public List<string> TargetMethods { get; set; }
            public string CreatedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public DateTime? ModifiedOn { get; set; }
        }
    }
}
