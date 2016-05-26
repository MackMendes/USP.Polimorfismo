using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USP.MicroAula.Domain.Entities;
using USP.MicroAula.Domain.Entities.Base;

namespace USP.MicroAula.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria contaCorrente = new ContaCorrente();
            ContaBancaria poupanca = new ContaPoupanca();

            // === Polimorfismo com Herança (sobrescrita)
            Console.WriteLine("======= Depositar ==========");
            Console.WriteLine($"{ contaCorrente.Depositar(500M) } Saldo atual: { contaCorrente.ObterSaldo() }");
            Console.WriteLine($"{ poupanca.Depositar(500M) } Saldo atual: { poupanca.ObterSaldo() }");
            Console.WriteLine("");
            Console.WriteLine("======= Sacar ==========");
            Console.WriteLine($"{ contaCorrente.Sacar(100M) } Saldo atual: { contaCorrente.ObterSaldo() }");
            Console.WriteLine($"{ poupanca.Sacar(100M) } Saldo atual: { poupanca.ObterSaldo() }");

            Console.ReadKey();

            // === Polimorfismo com sobrecarga de método
            Console.WriteLine("");
            Console.WriteLine("======= Obter Saldo ==========");
            Console.WriteLine(poupanca.ObterSaldo("Charles M"));

            Console.ReadKey();

        }
    }
}
