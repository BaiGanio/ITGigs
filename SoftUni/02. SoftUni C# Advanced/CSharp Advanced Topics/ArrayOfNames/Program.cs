using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string bunny = "Bugs Bunny";
            string zaek = "Зайко Байко";
            string гъска = "Гъска";
            string az = "Любен";
            string devil = "Tazmanian Devil";

            string[] names = {bunny, zaek, гъска, az, devil, "2", "Фики", "Kolkoto si iskam"};

            string[] cars = new string[5];
            cars[0] = "Audi";
            cars[1] = "Трабант";
            cars[2] = "Lada 1500S";
            cars[3] = "Mercedes";
            cars[4] = "Магарцидес";

            PrintSmileys(names);

            Console.WriteLine("------------------------------------------");

            PrintSmileys(cars);

        }

        static void PrintSmileys(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Name: {words[i]}  {(char)9786}");
            }
        }


    }
}
