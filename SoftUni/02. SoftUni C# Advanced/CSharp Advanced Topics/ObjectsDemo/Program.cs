using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student peshko = new Student();
            peshko.Town = "Каспичан";
            peshko.Age = 15;
            peshko.FacultyNumber = "57238979825";
            peshko.StudentName = "Петър плете плет преплита. Плети петре плети......";
            peshko.FavoriteVodka = "100 гайди";

            peshko.IntroduceYourself();

        }
    }
}
