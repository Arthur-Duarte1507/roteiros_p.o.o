namespace AppExcecoesEx03;

public sealed class LimiteDiarioException : Exception
{
    public LimiteDiarioException(decimal valorInformado, decimal limitePorOperacao)
        : base($"Saque acima do limite por operacao. Valor solicitado: {valorInformado:0.00}. Limite: {limitePorOperacao:0.00}.")
    {
        ValorInformado = valorInformado;
        LimitePorOperacao = limitePorOperacao;
    }

    public decimal ValorInformado { get; }

    public decimal LimitePorOperacao { get; }
}
