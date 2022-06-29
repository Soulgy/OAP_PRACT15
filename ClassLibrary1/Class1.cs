using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static bool Test(string index, string county, string city, string street, string numberhouse, string nuberoffice)
        {
            foreach (var item in index) if (!char.IsNumber(item)) return false;
            foreach (var item in county) if (!char.IsLetter(item)) return false;

            foreach (var item in city) if (!char.IsLetter(item)) return false;

            foreach (var item in street) if (!char.IsLetter(item)) return false;

            foreach (var item in nuberoffice) if (!char.IsNumber(item)) return false;
            foreach (var item in numberhouse) if (!char.IsNumber(item)) return false;

            return true;
        }
    }
}
