namespace USP.MicroAula.Domain.Entities
{
    public sealed class ContaPoupanca : Base.ContaBancaria
    {
        private void AplicaRendimentoPoupanca()
        {
            base.Saldo += 0.02m;
        }

        public override string Depositar(decimal valor)
        {
            this.AplicaRendimentoPoupanca();
            base.Saldo += valor;
            return $"Depósito do valor {valor} na CONTA POUPANÇA, foi realizado com sucesso.";
        }

        public override string Saquar(decimal valor)
        {
            if (valor <= 0 || (base.Saldo - valor) <= 0)
                return "Saldo insulficiente na CONTA POUPANÇA.";

            base.Saldo -= valor;
            return $"Saque do valor de {valor} na CONTA POUPANÇA, foi realizado com sucesso.";
        }
    }
}
