namespace USP.MicroAula.Domain.Entities
{
    public sealed class ContaCorrente : Base.ContaBancaria
    {
        private void CobrancaDeTaxa()
        {
            base.Saldo -= _valorTaxa;
        }

        private const decimal _valorTaxa = 15m;

        public override string Depositar(decimal valor)
        {
            base.Saldo += valor;
            return $"Depósito do valor {valor} na CONTA CORRENTE, foi realizado com sucesso.";
        }

        public override string Saquar(decimal valor)
        {
            var mensagemComplementar = string.Empty;

            if (valor < 0 || (base.Saldo - valor) < _valorTaxa)
                mensagemComplementar = "Porém, o saldo de sua CONTA CORRENTE, ficou com valor negativo.";

            this.CobrancaDeTaxa();
            base.Saldo -= valor;
            return $"Saque do valor de {valor} na CONTA CORRENTE, foi realizado com sucesso. {mensagemComplementar}";
        }
    }
}
