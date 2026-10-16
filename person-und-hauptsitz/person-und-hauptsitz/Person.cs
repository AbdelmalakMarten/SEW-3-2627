using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_und_hauptsitz
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string EMail { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public Adresse Hauptwohnsitz { get; set; }

        public Person()
        {

        }

        public int BerechneAlter(DateTime geburtsdatum)
        {
            int alster = 0;
            string datumString = geburtsdatum.ToString("dd.MM.yyyy");
            string[] teile = datumString.Split('.');
            int tag = int.Parse(teile[0]);
            int monat = int.Parse(teile[1]);
            int jahr = int.Parse(teile[2]);
            
            try
            {
                
            }
            catch 
            {
            
            }
            
            return alster;
        }
    }
}
