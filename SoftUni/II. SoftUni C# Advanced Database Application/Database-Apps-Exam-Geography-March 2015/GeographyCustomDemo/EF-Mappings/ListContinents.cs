using System;

namespace EF_Mappings
{
    class ListContinents
    {
        static void Main()
        {
            var ctx = new GeographyEntities();
            foreach (var country in ctx.Countries)
            {
                Console.WriteLine(country.CountryName);
            }
        }
    }
}
