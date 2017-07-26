using System;
using System.Collections.Generic;

namespace cstest
{
    public class Human
    {
        
        public Human(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }

        public string imie;
        public int wiek;

        public void sayHi()
        {
            Console.WriteLine($"Czesc, jestem {imie} i mam {wiek} lat.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();
            //Human h1 = new Human("Kazik", 17);
            humans.Add(new Human("Kazik", 17));
            humans.ForEach(c => c.sayHi());

            Console.ReadKey();
        }
    }
}