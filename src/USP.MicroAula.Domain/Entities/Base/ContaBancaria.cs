namespace USP.MicroAula.Domain.Entities.Base
{
    public abstract class ContaBancaria
    {
        protected decimal Saldo { get; set; }

        public string ObterSaldo()
        {
            // Quando incluir o R$, foi alterado em todos os "lugares", porque esse é um método que esta 
            // sendo utilizado em vários lugares. 
            return $"Seu saldo é: R$ {this.Saldo}";
        }

        public string ObterSaldo(string nomeCliente)
        {
            return $"Olá Sr(a). {nomeCliente}. " + ObterSaldo();
        }

        public abstract string Sacar(decimal valor);

        public abstract string Depositar(decimal valor);
    }
}
