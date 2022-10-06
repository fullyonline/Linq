using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {




        private static List<Student> _studentList;
        private static List<Education> _educationList;

        //TODO Struct Student
        private struct Student
        {
        }

        //TODO Struct Education
        private struct Education
        {
        }

        static void Main(string[] args)
        {
            InitialList();

            Console.WriteLine("Aufgabe 1");
            Console.WriteLine("--------------");
            //TODO Alle Studenten, die Wirtschaft studieren und über 18 Jahre alt sind. (Benützen Sie Extension Methods)
            







            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 2");
            Console.WriteLine("--------------");
            //TODO Alle Studenten, die unter 20 Jahre alt sind. (Benützen Sie Linq und übergeben Sie das Resultat auf ein anonymes Attribut). 
            









            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 3");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf. (Benützen Sie Linq-Abfrage)
            










            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 4");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf. (Benützen Sie Linq-Abfrage)
            










            Console.WriteLine("--------------");

            Console.WriteLine("Aufgabe 5");
            Console.WriteLine("--------------");
            //TODO Gruppieren Sie die Studentnamen unter dem Studienfach auf, die älter als 20 Jahre sind. (Benützen Sie Linq-Abfrage)
           











            Console.WriteLine("--------------");

            Console.ReadKey();
        }

        //TODO Listen auffüllen
        private static void InitialList()
        {
        }
    }
}
