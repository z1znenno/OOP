



using System.Net.WebSockets;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Isik inimene1 = new Isik();
            //inimene1.Nimi = "Mati";
            //inimene1.Sünniaasta = 2000;
            //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

            Koolihaldus minuKool = new Koolihaldus();
            List<ITooline> palgasaajad = new List<ITooline>();
            Random rnd = new Random();
            ITooline[] toolised = new ITooline[3]
            {
                new Opilane(),
                new Opetaja(),
                new UleOpilane()
            };

            //Õpetajad
            string[] õpetajaNimed = { "Marina", "Aleksei", "Katrin", "Dmitri", "Liisa" };
            int[] õpetajaSünniaastad = { 1975, 1982, 1990, 1995, 1988 };
            string[] ained = { "programmeerimine", "matemaatika", "füüsika", "keemia", "eesti keel" };
            double[] tunnitasud = { 13.8, 15.0, 12.5, 14.2, 16.0 };
            int[] tunnidKuus = { 120, 130, 140, 150, 160 };

            //Õpilased
            string[] õpilasNimed = { "Yaroslav", "Anna", "Peeter", "Maria", "Ivan" };
            int[] õpilasSünniaastad = { 2005, 2006, 2007, 2008, 2009 };
            string[] koolid = { "TTHK", "Gustav Adolfi Gümnaasium", "Tallinna Reaalkool" };
            int[] klassid = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
          
            int[] puudumised = { 0, 5, 10, 13, 20 };

            Oppevorm[] vormid = (Oppevorm[])Enum.GetValues(typeof(Oppevorm)); // teeb list

            for ( int i = 0; i < 5; i++)
            {
               
                int randomIsik = rnd.Next(0, 3);
                var tooline = toolised[randomIsik];
                switch (tooline)
                {
                    case UleOpilane:

                        UleOpilane üliõpilane = new UleOpilane();
                        üliõpilane.Nimi = õpilasNimed[rnd.Next(1, 5)];
                        üliõpilane.Synniaasta = õpilasSünniaastad[rnd.Next(1, 5)];
                        üliõpilane.Kool = koolid[rnd.Next(1, 3)];
                        üliõpilane.Klass = klassid[rnd.Next(1, 12)];
                        üliõpilane.Keskminehinne = rnd.NextDouble() * 5;
                        üliõpilane.Puudumised = puudumised[rnd.Next(1, 5)];
                        üliõpilane.SotsiaalAmet = rnd.Next(2) == 0; // random bool
                        üliõpilane.Staatus = vormid[rnd.Next(vormid.Length)];
                        üliõpilane.Eriala = "Infotehnoloogia";

                        üliõpilane.Kirjelda();
                        üliõpilane.Õpi();
                        üliõpilane.ArvutaPalk();
                        minuKool.LisaInimene(üliõpilane);
                        palgasaajad.Add(üliõpilane);
                        Console.WriteLine("===================================================");
                        break;
                    case Opilane:

                        Opilane õpilane = new Opilane();
                        õpilane.Nimi = õpilasNimed[rnd.Next(1, 5)];
                        õpilane.Synniaasta = õpilasSünniaastad[rnd.Next(1, 5)];
                        õpilane.Kool = koolid[rnd.Next(1, 3)];
                        õpilane.Klass = klassid[rnd.Next(1, 12)];
                        õpilane.Keskminehinne = rnd.NextDouble() * 5;
                        õpilane.Puudumised = puudumised[rnd.Next(1, 5)];
                        õpilane.SotsiaalAmet = rnd.Next(2) == 0; // random bool
                        õpilane.Staatus = vormid[rnd.Next(vormid.Length)];

                        õpilane.Kirjelda();
                        õpilane.Õpi();
                        õpilane.ArvutaPalk();
                        minuKool.LisaInimene(õpilane);
                        palgasaajad.Add(õpilane);
                        Console.WriteLine("===================================================");
                        break;


                    case Opetaja:

                        Opetaja õpetaja = new Opetaja();
                        õpetaja.Nimi = õpetajaNimed[rnd.Next(1, 5)];
                        õpetaja.Synniaasta = õpetajaSünniaastad[rnd.Next(1, 5)];
                        õpetaja.Aine = ained[rnd.Next(1, 5)];
                        õpetaja.Tunnitasu = tunnitasud[rnd.Next(1, 5)];
                        õpetaja.Tunnidkuus = tunnidKuus[rnd.Next(1, 5)];
                        palgasaajad.Add(õpetaja);
                        õpetaja.Kirjelda();
                        õpetaja.Opeta();
                        minuKool.LisaInimene(õpetaja);
                        Console.WriteLine("===================================================");
                        break;
                }



              
            }
            Console.WriteLine("---VÄLJAMAKSED---");
            foreach (ITooline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();
                Console.WriteLine($"{tüüp}. summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");

            }

            Console.WriteLine("================MINU KOOL==================");
            minuKool.KuvaKõik();
        }
    }    
}