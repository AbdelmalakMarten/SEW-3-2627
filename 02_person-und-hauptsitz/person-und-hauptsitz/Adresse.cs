using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_und_hauptsitz
{
    internal class Adresse
    {
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public int Plz { get; set; }
        public string Ort { get; set; }
        public string Bundesland { get; set; }
        public string Land { get; set; }

        public Adresse(string strasse, string hausnummer, int plz,string ort, string bundesland, string land = "Österreich")
        {
            try
            {
                if (strasse == "" || hausnummer == "" || ort == "" || bundesland == "" || land == "")
                {
                    Console.WriteLine("Texte dürfen nicht leer sein!");
                }
                else if (plz < 1000 || plz > 9999)
                {
                    Console.WriteLine("Ungültige PLZ!");
                }
                else

                {
                    Strasse = strasse;

                    Hausnummer = hausnummer;
                    Plz = plz;
                    Ort = ort;
                    Bundesland = bundesland;
                    Land = land;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Fehler bei der Adresse: " + ex.Message);
            }

        }

        public override string ToString()
        {
            return Strasse + " " + Hausnummer + ", " +Plz + " " + Ort + ", " + Bundesland;
        }

    }
    
}
