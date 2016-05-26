using System;
using USP.VideoAula.Domain.Common;
using USP.VideoAula.Domain.Entities;
using USP.VideoAula.Domain.Entities.Base;

namespace USP.VideoAula.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cachorro = new Cachorro();
            Animal gato = new Gato();

            // === Polimorfismo com Herança (sobrescrita)
            Console.WriteLine("======= Alimentar ==========");
            Console.WriteLine($"Cachorro come: { AnimalCommon.AnimalSeAlimentaCom(cachorro)}");
            Console.WriteLine($"Gato come: { AnimalCommon.AnimalSeAlimentaCom(gato)}");
            Console.WriteLine("");
            Console.WriteLine("======= Brincar ==========");
            Console.WriteLine($"Cachorro brinca: { AnimalCommon.AnimalBrincaCom(cachorro)}");
            Console.WriteLine($"Gato brinca: { AnimalCommon.AnimalBrincaCom(gato)}");

            Console.ReadKey();

            // === Polimorfismo com sobrecarga de método
            Console.WriteLine("");
            Console.WriteLine("======= Brincar ==========");
            Console.WriteLine($"Gato agora está brincando: {gato.Brincar("e com meu dono!")}");

            Console.ReadKey();
        }
    }
}
