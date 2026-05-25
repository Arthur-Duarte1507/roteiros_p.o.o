namespace AppExcecoesEx01;

public sealed class LimiteDepositoException : Exception
{
    public LimiteDepositoException(decimal valorInformado, decimal limitePermitido)
        : base($"Deposito acima do limite permitido. Valor informado: {valorInformado:0.00}. Limite por operacao: {limitePermitido:0.00}.")
    {
        ValorInformado = valorInformado;
        LimitePermitido = limitePermitido;
    }

    public decimal ValorInformado { get; }

    public decimal LimitePermitido { get; }
}
