using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Opetaja : Isik, ITooline
    {
        public string Aine { get; set; }

        public double Tunnitasu { get; set; }

        public int Tunnidkuus { get; set; }

        public TooTyyp VäljamakseTüüp { get; set; } = TooTyyp.Palk;

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
        public void Opeta()
        { 
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }

        public virtual double ArvutaPalk()
        {
            Console.WriteLine($"Õpetaja palk on: {Tunnitasu * Tunnidkuus}");
            return Tunnitasu * Tunnidkuus;
        }


    }
}