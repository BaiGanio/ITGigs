using Common;
using System;

namespace PassHasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pass: ");
            string pass = Console.ReadLine();
            Console.Write("Your hash code: ");
            Console.WriteLine(HashUtils.CreateHashCode(pass));
            Console.WriteLine();
            Console.WriteLine("bye bye!");
        }
    }
}
