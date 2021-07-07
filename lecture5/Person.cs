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

        public void SayHello()
        {
            Console.WriteLine($"{Name} {SurName} {Age}");
        }
    }
}