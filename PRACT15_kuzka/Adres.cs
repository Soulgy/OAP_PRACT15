using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACT15_kuzka
{
    internal class Adres
    {
       public static List<Adres> adresses = new List<Adres>();

        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int NumberHouse { get; set; }
        public int NumberOffice { get; set; }

        public Adres(int index, string county, string city, string street, int numberhouse, int nuberoffice)
        {
            Index = index;
            Country = county;
            City = city;
            Street = street;
            NumberHouse = numberhouse;
            NumberOffice = nuberoffice;
        }

        public static void AddAddress(Adres adres)
        {
            StreamWriter sw = File.AppendText("file1.txt");
            sw.WriteLine($"{adres.Index}={adres.Country}={adres.City}={adres.Street}={adres.NumberHouse}={adres.NumberOffice}");
            adresses.Add(adres);
            sw.Close();
        }

        public static void RemoveAddress(int index)
        {
            Adres adres = null;
            foreach(var elem in adresses)
            {
                if (elem.Index == index) adres = elem;
            }
            adresses.Remove(adres);

            StreamWriter sw = File.CreateText("file1.txt");
            foreach(var elem in adresses)
            {
                sw.WriteLine($"{elem.Index}={elem.Country}={elem.City}={elem.Street}={elem.NumberHouse}={elem.NumberOffice}");
            }
            sw.Close();
        }

    }
}
