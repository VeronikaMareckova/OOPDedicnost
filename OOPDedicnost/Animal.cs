using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDedicnost
{
    public abstract class Animal  //nezle z teto abstraktni tridy vytovorit OBJEKT 
    {
        //atributy
        private string zivocich;
        
        //Konstruktor
        public Animal(string zivocich)
        {
            this.zivocich = zivocich;
        }

        //GET metody
        public string GetZivocich()
        {
            return zivocich;
        }

        //SET metody
        public void SetZivocich(string value)
        {
            zivocich = value;
        }
        
        //Metody
        public virtual void PohybujSe() 
        {
            Console.Write("Pohybuji se pomocí ...");
        }
        public abstract void Pozdrav(); //abstract musi potomci dodat kod

        public void Spi()
        {
            Console.WriteLine("Zzzz :-)");
        }

        static public void Enter() //STATICKA metoda je dostupna rovnou pod tridou
        {
            Console.Write("\n");
        }
    }
}
