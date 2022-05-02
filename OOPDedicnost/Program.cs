using System;

namespace OOPDedicnost
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJEKT
            Animal Alik = new Dog("Pes");
            Animal Mica = new Cat("Kočka");
            Animal Andulka = new Bird("Pták");
            Animal Tonda = new Dolphin("Delfín");

            //výpis hodnot
            Console.WriteLine(Alik.GetZivocich());
            Console.WriteLine(Mica.GetZivocich());
            Console.WriteLine(Andulka.GetZivocich());
            Console.WriteLine(Tonda.GetZivocich());

            Animal.Enter(); //staticka metoda neni zde objekt.metoda ale TRIDA.METODA

            Console.WriteLine(Alik.GetZivocich());
            //Zavolani metody u objektu ALIK
            Alik.PohybujSe();
            Alik.Pozdrav();
            Alik.Spi();

            Animal.Enter(); //staticka metoda

            Console.WriteLine(Mica.GetZivocich());
            //Zavolani metody u objektu Mica
            Mica.PohybujSe();
            Mica.Pozdrav();
            Mica.Spi();

            Animal.Enter(); //staticka metoda

            Console.WriteLine(Andulka.GetZivocich());
            //Zavolani metody u objektu Andulka
            Andulka.PohybujSe();
            Andulka.Pozdrav();
            Andulka.Spi();

            Animal.Enter(); //staticka metoda

            Console.WriteLine(Tonda.GetZivocich());
            //Zavolani metody u objektu Tonda
            Tonda.PohybujSe();
            Tonda.Pozdrav();
            Tonda.Spi();
        }
    }
}
