using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AddLinq1.Model;

namespace AddLinq1
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new Repository();

            var abteilungListe = repo.GetAbteilungList();
            var mitarbeiterList = repo.GetMitarbeiterList();
            var projektListe = repo.GetProjekctList();

            Console.WriteLine("Aufgabe 1");
            Console.WriteLine("Eine Zeile --------------"); // Eine Zeile = object.Select(o => {})
            
            mitarbeiterList.ForEach(ma => {
                Console.WriteLine($"{ma.Name}\t{ma.Vorname}");
            });

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 2");
            Console.WriteLine("--------------");

            var aufg2Mas = from ma in mitarbeiterList
                           join abt in abteilungListe on ma.AbteilungID equals abt.AbteilungID
                           select new
                           {
                               Name = ma.Name,
                               Vorname = ma.Vorname,
                               Abteilung = abt.Name
                           };

            foreach(var ma in aufg2Mas)
            {
                Console.WriteLine($"{ma.Vorname}\t{ma.Name}\t-\t{ma.Abteilung}");
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 3");
            Console.WriteLine("--------------");

            var aufg3 = from ma in mitarbeiterList
                        join abt in abteilungListe on ma.AbteilungID equals abt.AbteilungID
                        join proj in projektListe on ma.ProjektID equals proj.ProjekteID
                        select new
                        {
                            Name = ma.Name,
                            Vorname = ma.Vorname,
                            Abteilung = abt.Name,
                            Projekt = proj.ProjektName
                        };

            foreach(var ma in aufg3)
            {
                Console.WriteLine($"{ma.Vorname}\t{ma.Name}\t-\t{ma.Abteilung}\t-\t{ma.Projekt}");
            }


            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 4");
            Console.WriteLine("--------------");

            var aufg4 = from ma in mitarbeiterList
                        join abt in abteilungListe on ma.AbteilungID equals abt.AbteilungID
                        join pro in projektListe on ma.ProjektID equals pro.ProjekteID
                        where abt.Name == "Mechanik"
                        select new
                        {
                            Name = ma.Name,
                            Vorname = ma.Vorname,
                            Abteilung = abt.Name,
                            Projekt = pro.ProjektName
                        };

            foreach(var ma in aufg4)
            {
                Console.WriteLine($"{ma.Vorname}\t{ma.Name}\t-\t{ma.Abteilung}\t-\t{ma.Projekt}");
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 5");
            Console.WriteLine("--------------");


            var aufg5 = from ma in mitarbeiterList
                        join abt in abteilungListe on ma.AbteilungID equals abt.AbteilungID
                        join pro in projektListe on ma.ProjektID equals pro.ProjekteID
                        where pro.ProjektName == "Mars"
                        select new
                        {
                            Name = ma.Name,
                            Vorname = ma.Vorname,
                            Abteilung = abt.Name,
                            Projekt = pro.ProjektName
                        };

            foreach (var ma in aufg5)
            {
                Console.WriteLine($"{ma.Vorname}\t{ma.Name}\t-\t{ma.Abteilung}\t-\t{ma.Projekt}");
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 6");
            Console.WriteLine("--------------");

            var aufg6a = from ma in mitarbeiterList
                        join abt in abteilungListe on ma.AbteilungID equals abt.AbteilungID
                        join pro in projektListe on ma.ProjektID equals pro.ProjekteID
                        where pro.ProjektName == "Erde" && abt.Name == "Software"
                        select new
                        {
                            Name = ma.Name,
                            Vorname = ma.Vorname,
                            Abteilung = abt.Name,
                            Projekt = pro.ProjektName
                        };

            foreach (var ma in aufg6a)
            {
                Console.WriteLine($"{ma.Vorname}\t{ma.Name}\t-\t{ma.Abteilung}\t-\t{ma.Projekt}");
            }

            Console.WriteLine("Eine Zeile--------------");

            var aufg6b = mitarbeiterList.Where(ma => projektListe.Where(pro => pro.ProjektName == "Erde").Any(item => item.ProjekteID == ma.ProjektID) && abteilungListe.Where(abt => abt.Name == "Software").Any(item => item.AbteilungID == ma.AbteilungID));

            foreach (var ma in aufg6b)
            {
                Console.WriteLine($"{ma.Vorname}\t{ma.Name}");
            }


            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 7");
            Console.WriteLine("Eine Zeile --------------");

            var aufg7 = mitarbeiterList.Where(ma => ma.Name.StartsWith("K"));

            foreach (var ma in aufg7)
            {
                Console.WriteLine($"{ma.Name}\t{ma.Vorname}");
            };

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 8");
            Console.WriteLine("Eine Zeile --------------");

            var aufg8 = mitarbeiterList.Where(ma => ma.Position == "Abteilungsleiter").Count();
            Console.WriteLine($"Anzahl Abteilungsleiter: {aufg8}");
            

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 9");
            Console.WriteLine("Eine Zeile --------------");

            var aufg9 = mitarbeiterList.Where(ma => projektListe.Where(pro => pro.ProjektName == "Mars").Any(pro => pro.ProjekteID == ma.ProjektID)).Count();
            Console.WriteLine($"Anzahl MAs von Mars Projekten: {aufg9}");

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 10");
            Console.WriteLine("--------------");

            Console.WriteLine("nur wenn Aufgabe 10 erreicht ist, dann auskommentieren");

            //TODO
            //repo.AddMitarbeiter(newMit);

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 11");
            Console.WriteLine("Eine Zeile --------------");

            //TODO

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 12");
            Console.WriteLine("Eine Zeile --------------");


            //TODO

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 13");
            Console.WriteLine("Auslassen --------------");

           

            Console.WriteLine("--------------");
            Console.WriteLine("Aufgabe 14");
            Console.WriteLine("Auslassen --------------");

            //TODO
                        

            Console.WriteLine("--------------");
            Console.ReadKey();
        }

    }
}
