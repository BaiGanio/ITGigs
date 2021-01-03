using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryDB.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicDictionaryDemo();
            string connString = "data source=.;  database=TechCorpDB; integrated security = SSPI";

            try
            {
                Dictionary<string, List<string>> countries = CountriesDictionary(connString);
                Console.WriteLine($"Total countries in dictionary = {countries.Count}");

                PrintCountries(countries);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        static void PrintCountries(Dictionary<string, List<string>> countries)
        {
            foreach (var pair in countries)
            {
                Console.WriteLine("{0} --> ", pair.Key);
                Console.WriteLine($"Population: {pair.Value[0]}");
                Console.WriteLine($"Capital: {pair.Value[1]}");
                Console.WriteLine("---------------------------------");
            }
        }

        static Dictionary<string, List<string>> CountriesDictionary(string connString)
        {
            Dictionary<string, List<string>> countries = new Dictionary<string, List<string>>();

            /* How to connect to SQL Server */
            SqlConnection conn = new SqlConnection(connString);

            /* Prepare command to execute */
            string sqlCommand = "select top(10) CountryName, Population, Capital from Countries";
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);

            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                /* Get the results */
                string countryName = (string)reader["CountryName"];
                int population = (int)reader["Population"];
                string capital = (string)reader["Capital"];

                List<string> currenCoutryInfo = new List<string>() { population.ToString(), capital };

                /* Save results in Dictionary */
                countries[countryName] = currenCoutryInfo;
            }

            return countries;
        }

        static void BasicDictionaryDemo()
        {
            Dictionary<string, List<string>> countries = new Dictionary<string, List<string>>();

            List<string> albania = new List<string>() { "Tirana", "2986952", "AL" };
            List<string> argentina = new List<string>() { "Buenos Aires", "41343201", "AR" };


            countries["Albania"] = albania;
            countries["Argentina"] = argentina;

            foreach (var pair in countries)
            {
                Console.WriteLine("{0} --> ", pair.Key);
                Console.WriteLine($"Capital: {pair.Value[0]}");
                Console.WriteLine($"Population: {pair.Value[1]}");
                Console.WriteLine($"Country Code: {pair.Value[2]}");
                Console.WriteLine("---------------------------------");
            }
        }

    }
}
