using System;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Opetaja opetaja1 = new Opetaja();
            opetaja1.Nimi = "Nadežda";
            opetaja1.Synniaasta = 1975;
            opetaja1.Aine = "Matemaatika";
            opetaja1.Tervita();
            opetaja1.Opeta();

            Opilane opilane1 = new Opilane();
            opilane1.Nimi = "Vitali";
            opilane1.Synniaasta = 2010;
            opilane1.Kool = "Tallinna Tööstushariduskeskus";
            opilane1.Klass = 10;
            opilane1.Tervita();
            opilane1.Opi(); 
        }
    }
}