namespace AppExcecoesEx03;

public sealed class Conta
{
    private const decimal LimiteDepositoPorOperacao = 10_000m;
    private const decimal LimiteSaquePorOperacao = 500m;

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

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "Valor do saque deve ser maior que zero.");
        }

        if (valor > LimiteSaquePorOperacao)
        {
            throw new LimiteDiarioException(valor, LimiteSaquePorOperacao);
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para saque.");
        }

        Saldo -= valor;
    }

    public void Transferir(Conta destino, decimal valor)
    {
        if (destino is null)
        {
            throw new ArgumentNullException(nameof(destino));
        }

        if (ReferenceEquals(this, destino))
        {
            throw new InvalidOperationException("Conta de origem e destino devem ser diferentes.");
        }

        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "Valor da transferencia deve ser maior que zero.");
        }

        if (valor > LimiteDepositoPorOperacao)
        {
            throw new LimiteDepositoException(valor, LimiteDepositoPorOperacao);
        }

        Sacar(valor);

        try
        {
            destino.Depositar(valor);
        }
        catch
        {
            Depositar(valor);
            throw;
        }
    }
}
