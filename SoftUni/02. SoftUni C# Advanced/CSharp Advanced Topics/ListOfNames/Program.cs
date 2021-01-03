using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> names =  new List<string>() { "Peter", "Maria", "Katya", "Todor",  "2", "Фики", "Kolkoto si iskam" };
            names.Add("Nakov"); // Peter, Maria, Katya, Todor, Nakov
            names.RemoveAt(0); // Maria, Katya, Todor, Nakov
            //names.Insert(3, "Sylvia"); // Maria, Katya, Todor, Sylvia, Nakov
            //names[1] = "Michael"; // Maria, Michael, Todor, Sylvia, Nakov
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
