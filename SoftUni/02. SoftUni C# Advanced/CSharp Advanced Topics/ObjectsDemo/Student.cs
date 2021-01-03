using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsDemo
{
    public class Student
    {
        public string FacultyNumber { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
        public string FavoriteVodka { get; set; }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello! My name is {StudentName}. I'm from {Town} & I'm {Age} old. I like to drink {FavoriteVodka}");
        }

    }
}
