using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterMusicProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

             // 1 Euro = 1.94lv
            decimal euro = 1.94m;
            // 1 USD = 1.72lv
            decimal usd = 1.72m;
            // 332.74 pesos = 1lv
            decimal levPesos = 332.74m;

              // The producer takes 35% from all profits. The band must pay 20% taxes on the rest of the income
            decimal producer = 35/100m;
            decimal producerConcerts = 15/100m;
            decimal taxes = 20/100m;
            
            //1.	The number of albums sold in Europe
            //2.	The price of an album in euro
            //3.	The number of albums sold in North America
            //4.	The price of an album in dollars
            //5.	The number of albums sold in South America
            //6.	Price of an album in pesos
            //7.	The number of concerts during a tour
            //8.	Profit from a single concert in euro

        

          

            int albumsSoldInEurope = int.Parse(Console.ReadLine());
            decimal albumPriceInEuro = decimal.Parse(Console.ReadLine());

            int albumsSoldInNorthAmerica = int.Parse(Console.ReadLine());
            decimal albumPriceInNorthAmerica = decimal.Parse(Console.ReadLine());

            int albumsSoldInSouthAmerica = int.Parse(Console.ReadLine());
            decimal albumPriceInSouthAmerica = decimal.Parse(Console.ReadLine());

            int concertsPerTour = int.Parse(Console.ReadLine());
            decimal profitFromSingleConcertInEuro = decimal.Parse(Console.ReadLine());

            // Logic

            decimal profitInEurope = (albumsSoldInEurope * albumPriceInEuro) * euro;
            decimal profitInNAmerica = (albumsSoldInNorthAmerica * albumPriceInNorthAmerica) * usd;
            decimal profitInSAmerica = (albumsSoldInSouthAmerica * albumPriceInSouthAmerica)/levPesos;
            decimal currentFromAlbums = profitInEurope + profitInNAmerica + profitInSAmerica;
            decimal totalFromAlbums = currentFromAlbums - (currentFromAlbums*producer);
            decimal clearProfitFromAlbums = totalFromAlbums - (totalFromAlbums*taxes);

            decimal profitFromConcerts = concertsPerTour*profitFromSingleConcertInEuro;
            decimal clearProfitFromConcerts = 0;
            if (profitFromConcerts > 100000)
            {
                clearProfitFromConcerts = profitFromConcerts - (profitFromConcerts*producerConcerts);
            }

            //Console.WriteLine(profitInEurope);
            //Console.WriteLine(profitInNAmerica);
            //Console.WriteLine(profitInSAmerica);
            Console.WriteLine("Concerts => " +  clearProfitFromConcerts);
            Console.WriteLine("Albums => " + clearProfitFromAlbums);




        }
    }
}
