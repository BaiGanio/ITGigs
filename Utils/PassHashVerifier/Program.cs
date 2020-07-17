using Common;
using System;

namespace PassHashVerifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "123456";
            string passHash = "mwzOeHBGlqedP7Q0/6iEI7Pr1HS52c3ASAZ7S3oQKr1oFdhi";
            bool isVerified = HashUtils.VerifyPassword(pass, passHash);
            Console.WriteLine($"Is correct password: [{isVerified}]");
        }
    }
}
