using System;

namespace lecture5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*            var car1 = new Car();

                        car1.Name = "BMW";
                        car1.Age = 10;*/

            var person1 = new Person("Algis", "Pagerintas", 33);
            var person2 = new Person("Alfonsas", "Tiniginis", 73);
            var person3 = new Person("Egle", "Motiejuke", 50);
            var person4 = new Person("Ona", "Analginaite", 24);
            var person5 = new Person("Jurgis", "Antanas", 12);

            person1.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person2.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person3.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person4.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person5.SayHello();

            ;
            Person[] vardai = new Person[] { person1, person2, person3, person4, person5 };
            //daro lygiai ta pati. var pasikeicia i 'Person[]'
            //var vardai = new Person[] { person1, person2, person3, person4, person5 }

            foreach (var person in vardai)
            {
                Console.WriteLine($"{person.Name} {person.SurName} {person.Age}");
            }

            Console.WriteLine(Calculator.Add(5, 6));
            // issaukiam kiek susikure tu Personu kuriant
            Console.WriteLine(Person.PersonCount);
        }
    }

    // klase yra kaip sablonas, su kuriuo galime kurti naujus objektus. Tai yra mūsų sukurtas duomenų tipas
    /*    internal class Car
        {
            public string Name;
            public int Age;
        }*/
}