namespace AppExcecoesEx08;

public sealed class Conta
{
    private const decimal LimiteSaquePorOperacao = 500m;
    private const decimal LimiteSaqueDiario = 1_000m;
    private decimal _totalSacadoNoDia;

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

    public decimal TotalSacadoNoDia => _totalSacadoNoDia;

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "Valor do deposito deve ser maior que zero.");
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
            throw new LimitePorOperacaoException(valor, LimiteSaquePorOperacao);
        }

        decimal totalAposSaque = _totalSacadoNoDia + valor;
        if (totalAposSaque > LimiteSaqueDiario)
        {
            throw new LimiteSaqueDiarioException(_totalSacadoNoDia, valor, LimiteSaqueDiario);
        }

        if (valor > Saldo)
        {
            throw new InvalidOperationException("Saldo insuficiente para saque.");
        }

        Saldo -= valor;
        _totalSacadoNoDia = totalAposSaque;
    }

    public void IniciarNovoDia()
    {
        _totalSacadoNoDia = 0m;
    }
}
