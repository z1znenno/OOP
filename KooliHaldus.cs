using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   

    public class Koolihaldus
    {
        // Kapseldatud list
        private List<Isik> inimesed = new List<Isik>();

        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                isik.Kirjelda();
            }
        }

        public void OtsiNimeJargi(string nimi)
        {
            bool leitud = false;
            Console.WriteLine($"\n--- OTSING: {nimi} ---");
            foreach (var isik in inimesed)
            {
                if (isik.Nimi.Equals(nimi, StringComparison.OrdinalIgnoreCase))
                {
                    isik.Kirjelda();
                    Console.WriteLine("------------------------------------------------");
                    leitud = true;
                }
            }
            
            if (!leitud)
            {
                Console.WriteLine("Isikut nimega " + nimi + " ei leitud.");
            }
        }
    }

   
}