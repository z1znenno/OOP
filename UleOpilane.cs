namespace OOP
{
    public class UleOpilane : Opilane
    {
        public string Eriala { get; set; }
        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib {Klass}. klassis. Vorm: {Staatus}");
        }
    }
}