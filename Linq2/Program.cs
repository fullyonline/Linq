using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    //1
    delegate bool IsTeenAger(Student stud);
    //2
    delegate void Print();
    //3
    delegate bool IsYoungerThan(Student stud, int youngAge);
    class Program
    {
        static void Main(string[] args)
        {
            //1
            IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };
            var stud1 = new Student() { Age = 25 };
            Console.WriteLine(isTeenAger(stud1));

            //2
            Print print = () => Console.WriteLine("This is parameter less lambda expression");
            print();


            //3
            IsYoungerThan isYoungerThan = (s, youngAge) => {

                Console.WriteLine("Lambda expression with multiple statements in the body");

                return s.Age < youngAge;
            };
            Student stud = new Student() { Age = 25 };
            Console.WriteLine(isYoungerThan(stud, 26));

            Console.ReadKey();
        }
    }

    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
