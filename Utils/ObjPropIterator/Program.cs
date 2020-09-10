using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ObjPropIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate;
            DateTime.TryParse("fiki", out currentDate);
            MyClass mc = new MyClass(2,"fiki");

            PropertyInfo[] properties = mc.GetType().GetProperties();
            var searchParams = new List<object>();

            foreach (PropertyInfo pi in properties)
            {
               // Console.WriteLine(pi.Name);
                if (pi.GetValue(mc, null) != null)
                {
                    searchParams.Add(pi.GetValue(mc, null));
                }
            }

            foreach (var item in searchParams)
            {

                Console.WriteLine(item);
            }
        }

        class MyClass
        {
            public MyClass(int? miki, string fiki)
            {
                this.Miki = miki;
                this.Fiki = fiki;
            }
            public int? Miki { get; set; }
            public string Fiki { get; set; }
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Town { get; set; }
            public string PostCode { get; set; }
            public string HouseNumber { get; set; }
            public override string ToString()
            {
                return $"{this.Miki==null} = {string.IsNullOrEmpty(this.Fiki)}";
            }
        }
    }
}
