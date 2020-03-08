using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    static class TableOfPersons
    {
        public static List<Person> Datas = new List<Person>();
       
    }

    class Person
    {
        public string Imie
        { get; set; }

        public string Nazwisko
        { get; set; }

        public string Adres
        { get; set; }

    }
}
