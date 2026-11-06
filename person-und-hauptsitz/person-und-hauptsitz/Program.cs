using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_und_hauptsitz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Adresse a1 = new Adresse("Hauptstraße", "1", 3340, "Waidhofen", "Niederösterreich");
                Adresse a2 = new Adresse("Bahnhofstraße", "5", 1010, "Wien", "Wien");
                Adresse a3 = new Adresse("Dorfstraße", "10", 4020, "Linz", "Oberösterreich");
                Adresse a4 = new Adresse("Schulstraße", "3", 5020, "Salzburg", "Salzburg");

                
                List<Person> personen = new List<Person>();

                personen.Add(new Person(1, "Max", "Muster", "max@gmail.com", new DateTime(2005, 3, 12), a1));
                personen.Add(new Person(2, "Anna", "Muster", "anna@gmail.com", new DateTime(2008, 5, 20), a1));
                personen.Add(new Person(3, "Peter", "Maier", "peter@gmail.com", new DateTime(1990, 7, 10), a2));
                personen.Add(new Person(4, "Lisa", "Huber", "lisa@gmail.com", new DateTime(2000, 2, 15), a2));
                personen.Add(new Person(5, "Tom", "Berger", "tom@gmail.com", new DateTime(2003, 9, 8), a3));
                personen.Add(new Person(6, "Laura", "Bauer", "laura@gmail.com", new DateTime(1995, 1, 25), a3));
                personen.Add(new Person(7, "Paul", "Müller", "paul@gmail.com", new DateTime(1985, 6, 17), a3));
                personen.Add(new Person(8, "Julia", "Wagner", "julia@gmail.com", new DateTime(2007, 4, 3), a4));
                personen.Add(new Person(9, "David", "Schmidt", "david@gmail.com", new DateTime(1998, 8, 11), a4));
                personen.Add(new Person(10, "Sarah", "Weber", "sarah@gmail.com", new DateTime(2002, 12, 1), a4));

                
                Console.WriteLine("ALLE PERSONEN:");

                foreach (Person p in personen)
                {
                    Console.WriteLine(p);
                }

                
                int gesamtAlter = 0;

                foreach (Person p in personen)
                {
                    gesamtAlter += p.BerechneAlter();
                }

                double durchschnitt = (double)gesamtAlter / personen.Count;

                Console.WriteLine("Durchschnittsalter: " + durchschnitt);

                
                Console.WriteLine("ADRESSEN:");

                Adresse[] adressen = { a1, a2, a3, a4 };

                foreach (Adresse a in adressen)
                {
                    int anzahl = 0;

                    Console.WriteLine( a);

                    foreach (Person p in personen)
                    {
                        if (p.Hauptwohnsitz == a)
                        {
                            Console.WriteLine("- " + p.VollerName());
                            anzahl++;
                        }
                    }

                    Console.WriteLine("Anzahl Personen: " + anzahl);
                }

                
                Console.WriteLine("Bundesland eingeben:");
                string gesucht = Console.ReadLine();

                foreach (Person p in personen)
                {
                    if (p.Hauptwohnsitz.Bundesland.ToLower() == gesucht.ToLower())
                    {
                        Console.WriteLine(p.VollerName());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten: " + ex.Message);
            }

            Console.ReadKey();
        
        }
    }
}
