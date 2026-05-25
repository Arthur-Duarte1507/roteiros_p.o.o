namespace AppExcecoesEx04;

public sealed class Conta
{
    public Conta(string numero, decimal saldoInicial)
    {
        Numero = string.IsNullOrWhiteSpace(numero)
            ? throw new ArgumentException("Numero da conta e obrigatorio.", nameof(numero))
            : numero;

        if (saldoInicial < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(saldoInicial), "Saldo inicial nao pode ser negativo.");
        }

        Saldo = saldoInicial;
    }

    public string Numero { get; }

    public decimal Saldo { get; private set; }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "Valor do saque deve ser maior que zero.");
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para saque.");
        }

        Saldo -= valor;
    }
}
