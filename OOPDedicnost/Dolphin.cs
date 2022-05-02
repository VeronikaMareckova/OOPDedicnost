using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnost
{
    class Dolphin : Animal
    {
        //Konstruktor predka
        public Dolphin(string zivocich) : base(zivocich)
        {
        }

        //Zdedena virtualni metoda tj. uz s nejakym kodem
        public override void PohybujSe()
        {
            base.PohybujSe(); //zdedi se kod od predka
            Console.WriteLine("... ploutví.");
        }

        //Zdedena abstraktni tj. povinna metoda
        public override void Pozdrav()
        {
            Console.WriteLine("Skrr");
        }

    }
}
