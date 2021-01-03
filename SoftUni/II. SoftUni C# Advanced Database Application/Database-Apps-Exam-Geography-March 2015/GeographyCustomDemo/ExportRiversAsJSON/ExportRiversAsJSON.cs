using System;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using EF_Mappings;

namespace ExportRiversAsJSON
{
    class ExportRiversAsJSON
    {
        static void Main()
        {
            var ctx = new GeographyEntities();

            var riverQuery = ctx.Rivers
                .OrderByDescending(r => r.Length)
                .Select(r => new
                {
                    riverName = r.RiverName,
                    riverLength = r.Length,
                    countries = r.Countries
                    .OrderBy(c => c.CountryName)
                    .Select(c => c.CountryName)
                });

            //Console.WriteLine(riverQuery);
            //foreach (var river in riverQuery)
            //{
            //    Console.WriteLine(river.riverName);
            //}

            var river2Json = new JavaScriptSerializer().Serialize(riverQuery.ToList());
            File.WriteAllText(@"rivers.json", river2Json);


        }
    }
}
