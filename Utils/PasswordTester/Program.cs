using Common;
using System;

namespace PasswordTester
{
    class Program
    {
        static void Main(string[] args)
        {

            string pass = "4hun+dred"; //-FAIL
            string pass1 = "MyPassword1="; //OK
            string pass2 = "MyPassword1+="; //` -OK
            string hash = HashUtils.CreateHashCode(pass);
            string hash1 = HashUtils.CreateHashCode(pass1);
            string hash2 = HashUtils.CreateHashCode(pass2);
            string[] passwords = new string[] { pass, pass1, pass2 };
            string[] hashes = new string[] { hash, hash1, hash2 };

            for (int i = 0; i < passwords.Length; i++)
            {
                if (i == 0)
                {
                    passwords[i] = "4hun+dred";
                }
                bool isVerified = HashUtils.VerifyPassword(passwords[i], hashes[i]);
                Console.WriteLine($"Is correct password : [{isVerified}] => {passwords[i]} and hash is: {hashes[i]}");
            }

            Console.WriteLine(new string('*', 15));
        }
    }
}
