namespace AppExcecoesEx08;

public sealed class LimitePorOperacaoException : Exception
{
    public LimitePorOperacaoException(decimal valorInformado, decimal limitePermitido)
        : base($"Saque acima do limite por operacao. Valor solicitado: {valorInformado:0.00}. Limite: {limitePermitido:0.00}.")
    {
        ValorInformado = valorInformado;
        LimitePermitido = limitePermitido;
    }

    public decimal ValorInformado { get; }

    public decimal LimitePermitido { get; }
}
