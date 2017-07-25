using System;

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
            Human h1 = new Human("Kazik", 17);
            Human h2 = new Human("Mati", 17);
            Human h3 = new Human("Naczer", 15);

            h1.sayHi();
            h2.sayHi();
            h3.sayHi();

            Console.ReadKey();
        }
    }
}