namespace USP.MicroAula.Domain.Entities.Base
{
    public abstract class ContaBancaria
    {
        protected decimal Saldo { get; set; }

        public string ObterSaldo()
        {
            return $"Seu saldo é: {this.Saldo}";
        }

        public string ObterSaldo(string nomeCliente)
        {
            return $"Olá Sr(a). {nomeCliente}. " + ObterSaldo();
        }

        public abstract string Saquar(decimal valor);

        public abstract string Depositar(decimal valor);
    }
}
