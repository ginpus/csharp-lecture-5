using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture5
{
    /*        Sukurti naują tipą/klasę pavadinimu "Person" su 3 kintamaisiais(Name, Surname, Age)
    Nebenaudojam žodelio static!
    ● main metode sukurti 5 egzempliorius, objektus Asmuo.Kiekvienam iš egzempliorių priskirti kitą vardą ir metus
    ● Atspausdinti objekto kintamuosius į konsolę
    ● Sukurti metodą pavadinimu "SayHello", kuris išvestų į konsolę pasisveikinimo žinutę*/

    internal class Person
    {
        public string Name;
        public string SurName;
        public int Age;

        //statinis kintamasis
        public static int PersonCount;

        public void SayHello()
        {
            Console.WriteLine($"{Name} {SurName} {Age}");
        }

        // konstruktorius yra klases dalis ir kvieciamas kaip metodas klases iskvietimo metu. jis egzistuoja by default, bet yra tuscias
        // sukurus, konstruktoriu galim panaudoti tik paduodant su parametrais
        public Person(string name, string surname, int age)
        {
            Name = name;
            Age = age;
            SurName = surname;
            //statinis kitnamasis, kuris skaiciuoja, kiek kartu buvo panaudotas konstruktorius
            PersonCount++;
        }

        // galima sukurti daugiau nei viena konstruktoriu. Jei be parametru, tai tada sukuriam tuscia ir bus galima
        public Person(string Name)
        {
            //this pointina i butent toje klaseje esanti kitnamaji
            this.Name = Name;
        }

        // static naudojamas kuriant statinius metodas. jis yra klases metodas ir jo nereikia inicializuoti. negalima pasiekti ne'static fieldo
    }
}