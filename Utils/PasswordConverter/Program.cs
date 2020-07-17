using Common;
using System;

namespace PasswordConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password: ");
            string password = HashUtils.HidePassword('*');
            Console.WriteLine($"Chars entered: {password}");
        }
    }
}
