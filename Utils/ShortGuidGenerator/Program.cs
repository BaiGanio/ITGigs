using Common.Extensions;
using System;

namespace ShortGuidGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var g =Guid.NewGuid();
            ShortGuid sg = g;
            Console.WriteLine(sg);
        }
    }
}
