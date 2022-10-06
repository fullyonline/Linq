using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
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
            Console.WriteLine("Eine Zeile --------------");

            //TODO

            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 2");
            Console.WriteLine("--------------");

            //TODO

            Console.WriteLine("--------------");


            Console.WriteLine("Aufgabe 3");
            Console.WriteLine("--------------");

            //TODO

            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 4");
            Console.WriteLine("--------------");

            //TODO

            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 5");
            Console.WriteLine("--------------");

            //TODO

            Console.WriteLine("--------------");


            Console.WriteLine("Aufgabe 6");
            Console.WriteLine("--------------");

            //TODO

            Console.WriteLine("Eine Zeile--------------");


            //TODO

            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 7");
            Console.WriteLine("Eine Zeile --------------");

            //TODO

            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 8");
            Console.WriteLine("Eine Zeile --------------");

            //TODO

            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 9");
            Console.WriteLine("Eine Zeile --------------");

            //TODO

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
