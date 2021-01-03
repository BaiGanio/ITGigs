using System;
using System.Linq;
using System.Xml.Linq;
using EF_Mappings;

namespace ExportMonasteriesAsXML
{
    class ExportMonasteriesAsXML
    {
        static void Main()
        {
            var ctx = new GeographyEntities();

            var countriesQuery = ctx.Countries
                .OrderBy(c => c.CountryName)
                .Where(c => c.Monasteries.Any())
                .Select(c => new
                {
                    countryName = c.CountryName,
                    monasteries = c.Monasteries
                        .OrderBy(m => m.Name)
                        .Select(m => m.Name)
                });

            var xmlDoc = new XDocument();
            var xmlRoot = new XElement("monasteries");
            xmlDoc.Add(xmlRoot);

            foreach (var country in countriesQuery)
            {
                var countryXml = new XElement("country", new XAttribute("name", country.countryName));
                xmlRoot.Add(countryXml);

                foreach (var monastery in country.monasteries)
                {
                    var monasteryXml = new XElement("monastery",monastery);
                    countryXml.Add(monasteryXml);
                }
            }

            xmlDoc.Save("monasteries.xml");
            Console.WriteLine("Done!");
        }
    }
}
