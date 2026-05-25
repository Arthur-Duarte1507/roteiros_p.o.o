namespace AppExcecoesEx08;

public sealed class LimiteSaqueDiarioException : Exception
{
    public LimiteSaqueDiarioException(decimal totalAtual, decimal valorSolicitado, decimal limiteDiario)
        : base($"Limite diario excedido. Total atual: {totalAtual:0.00}, tentativa: {valorSolicitado:0.00}, limite: {limiteDiario:0.00}.")
    {
        TotalAtual = totalAtual;
        ValorSolicitado = valorSolicitado;
        LimiteDiario = limiteDiario;
    }

    public decimal TotalAtual { get; }

    public decimal ValorSolicitado { get; }

    public decimal LimiteDiario { get; }
}
