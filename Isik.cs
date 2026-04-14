namespace OOP
{
    public abstract class Isik
    {
        // Privaatne väli - otse ligi ei saa
        private int synniaasta;

        // Avalik omadus (Property) automaatse get/set logikaga
        public string Nimi { get; set; }

        // Kontrollitud omadus
        public int Synniaasta
        {
            get { return synniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    synniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
            }
        }

        // Arvutatud omadus (ainult lugemiseks / getter)
        public int Vanus => DateTime.Now.Year - synniaasta;
        // Tegevus ehk meetod
        public void Tervita()
        {
            if (string.IsNullOrEmpty(Nimi) || synniaasta == 0)
                Console.WriteLine("Tere! Mina ei tea veel oma nime ega sünniaastat.");
            else
                Console.WriteLine($"Tere! Mina olen {Nimi}. Olen {Synniaasta} aastal sündinud. Ma olen {Vanus} aastat vana.");
        }
        public abstract void Kirjelda();
    }
}