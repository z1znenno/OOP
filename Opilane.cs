namespace OOP
{
    public class Opilane : Isik
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public void Opi()
        {
            System.Console.WriteLine("Ma õpin koolis " + Kool + " klassis " + Klass);
        }
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja ma õpin {Kool} koolis klassis {Klass}.");
        }
    }
}