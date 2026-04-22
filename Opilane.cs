using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OOP
{
   
    public class Opilane : Isik, ITooline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double Keskminehinne { get; set; }
        public int Puudumised { get; set; } = 0;

        public bool SotsiaalAmet { get; set; }

        public TooTyyp VäljamakseTüüp { get; set; } = TooTyyp.Toetus;

        public Oppevorm Staatus { get; set; } = Oppevorm.Päevane;

      

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}");
        }


        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }



        double Põhitoestus = 0;
        double Eritoetust = 0;
        public double ArvutaPalk()
        {
            if (Keskminehinne > 3.8F && Puudumised < 30)
            {
                Põhitoestus = 60;
                Console.WriteLine("Õpilanel on põhitoetust");
                
            }

            if (SotsiaalAmet)
            {
                 Eritoetust = 120;
                 Console.WriteLine("Õpilanel on eritoetust");
            }
            Console.WriteLine($"Õpilane palk on: {Põhitoestus + Eritoetust}");

                return  Põhitoestus + Eritoetust;



        }
    }
}