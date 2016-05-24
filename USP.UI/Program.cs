using System;
using USP.Domain.Entities;
using USP.Domain.Entities.Base;

namespace USP.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cachorro = new Cachorro();
            Animal gato = new Gato();

            // === Polimorfismo com Herança (sobrescrita)
            Console.WriteLine("======= Alimentar ==========");
            Console.WriteLine("Cachorro come: " + cachorro.Alimentar());
            Console.WriteLine("Gato come: " + gato.Alimentar());
            Console.WriteLine("");
            Console.WriteLine("======= Brincar ==========");
            Console.WriteLine("Cachorro brinca: " + cachorro.Brincar());
            Console.WriteLine("Gato brinca: " + gato.Brincar());

            Console.ReadKey();

            // === Polimorfismo com sobrecarga de método
            Console.WriteLine("");
            Console.WriteLine("======= Brincar ==========");
            Console.WriteLine("Gato agora está brincando: " + gato.Brincar("e com meu dono!"));

            Console.ReadKey();
        }
    }
}
