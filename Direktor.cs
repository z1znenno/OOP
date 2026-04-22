namespace OOP
{
    public class Direktor : Opetaja
    {
        public double Lisatasu { get; set; }
        public override double ArvutaPalk()
        {
            System.Console.WriteLine($"Direktor palk on: {base.ArvutaPalk() + Lisatasu} eurot.");
            return base.ArvutaPalk() + Lisatasu;
        }
    }
}