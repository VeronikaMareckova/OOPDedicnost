using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnost
{
    class Cat : Animal
    {
        //Konstruktor predka
        public Cat(string zivocich) : base(zivocich)
        {
        }

        //Zdedena virtualni metoda tj. uz s nejakym kodem
        public override void PohybujSe()
        {
            base.PohybujSe();//zdedi se kod od predka
            Console.WriteLine("... 4 kočičích pacek.");
        }

        //Zdedena abstraktni tj. povinna metoda
        public override void Pozdrav()
        {
            Console.WriteLine("Mňau");
        }
    }
}
