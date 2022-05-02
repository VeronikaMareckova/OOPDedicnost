using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnost
{
    class Dog : Animal
    {
        //Konstruktor predka
        public Dog(string zivocich ) : base(zivocich)
        {
        }

        //Zdedena virtualni metoda tj. uz s nejakym kodem
        public override void PohybujSe()
        {
            base.PohybujSe(); //zdedi se kod od predka
            Console.WriteLine(" ... 4 psích pacek.");
        }

        //Zdedena abstraktni tj. povinna metoda
        public override void Pozdrav()
        {
            Console.WriteLine("HAF");
        }

    }
}
