namespace OOP
{
    public class Opetaja : Isik
    {
        public string Aine { get; set; }
        public void Opeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan {Aine}.");
        }
    }
}