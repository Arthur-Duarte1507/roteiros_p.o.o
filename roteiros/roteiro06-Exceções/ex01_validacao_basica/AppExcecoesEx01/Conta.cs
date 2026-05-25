namespace AppExcecoesEx01;

public sealed class Conta
{
    private const decimal LimiteDepositoPorOperacao = 10_000m;

    public Conta(string numero, decimal saldoInicial)
    {
        if (string.IsNullOrWhiteSpace(numero))
        {
            throw new ArgumentException("Numero da conta e obrigatorio.", nameof(numero));
        }

        if (saldoInicial < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(saldoInicial), "Saldo inicial nao pode ser negativo.");
        }

        Numero = numero;
        Saldo = saldoInicial;
    }

    public string Numero { get; }

    public decimal Saldo { get; private set; }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "Valor do deposito deve ser maior que zero.");
        }

        if (valor > LimiteDepositoPorOperacao)
        {
            throw new LimiteDepositoException(valor, LimiteDepositoPorOperacao);
        }

        Saldo += valor;
    }
}
