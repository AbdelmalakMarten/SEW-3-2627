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
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public Adresse Hauptwohnsitz { get; set; }

        public Person(int id, string vorname, string nachname,string email, DateTime geburtsdatum, Adresse hauptwohnsitz)
        {
            try
            {
                if (vorname == "" || nachname == "" || email == "")
                {
                    Console.WriteLine("Daten dürfen nicht leer sein!");
                }
                else if (!email.Contains("@"))
                {
                    Console.WriteLine("Ungültige Email!");
                }
                else if (geburtsdatum > DateTime.Now)
                {
                    Console.WriteLine("Geburtsdatum liegt in der Zukunft!");
                }
                else if (hauptwohnsitz == null)
                {
                    Console.WriteLine("Hauptwohnsitz darf nicht null sein!");
                }
                else
                {
                    Id = id;
                    Vorname = vorname;
                    Nachname = nachname;
                    Email = email;
                    Geburtsdatum = geburtsdatum;
                    Hauptwohnsitz = hauptwohnsitz;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler bei der Person: " + ex.Message);
            }
        }

        public int BerechneAlter()
        {
            int alter = DateTime.Now.Year - Geburtsdatum.Year;

            if (DateTime.Now < Geburtsdatum.AddYears(alter))
            {
                alter--;
            }

            return alter;
        }

        public string VollerName()
        {
            return Vorname + " " + Nachname;
        }

        public override string ToString()
        {
            return Id + ": " + VollerName() +
                   ", Alter: " + BerechneAlter() +
                   ", Email: " + Email +
                   ", Adresse: " + Hauptwohnsitz;
        }
    }
}
