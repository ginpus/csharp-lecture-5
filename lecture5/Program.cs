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

            var person1 = new Person();
            var person2 = new Person();
            var person3 = new Person();
            var person4 = new Person();
            var person5 = new Person();

            person1.Name = "Algis";
            person1.SurName = "Pagerintas";
            person1.Age = 33;
            person1.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person2.Name = "Alfonsas";
            person2.SurName = "Tiniginis";
            person2.Age = 73;
            person2.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person3.Name = "Egle";
            person3.SurName = "Motiejuke";
            person3.Age = 50;
            person3.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person4.Name = "Ona";
            person4.SurName = "Analginaite";
            person4.Age = 24;
            person4.SayHello();
            Console.WriteLine("------------------Kitas asmuo---------------------");
            person5.Name = "Jurgis";
            person5.SurName = "Antanas";
            person5.Age = 12;
            person5.SayHello();
        }

        /*        Sukurti naują tipą/klasę pavadinimu "Person" su 3 kintamaisiais(Name, Surname, Age)
        Nebenaudojam žodelio static!
        ● main metode sukurti 5 egzempliorius, objektus Asmuo.Kiekvienam iš egzempliorių priskirti kitą vardą ir metus
        ● Atspausdinti objekto kintamuosius į konsolę
        ● Sukurti metodą pavadinimu "SayHello", kuris išvestų į konsolę pasisveikinimo žinutę*/
    }

    // klase yra kaip sablonas, su kuriuo galime kurti naujus objektus. Tai yra mūsų sukurtas duomenų tipas
    /*    internal class Car
        {
            public string Name;
            public int Age;
        }*/
}