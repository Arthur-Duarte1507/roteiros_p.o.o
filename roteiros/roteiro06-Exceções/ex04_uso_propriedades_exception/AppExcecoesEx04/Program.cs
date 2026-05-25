using AppExcecoesEx04;

Conta conta = new("001", 100m);

try
{
    ProcessarSaque(conta, 200m);
}
catch (Exception ex)
{
    Console.WriteLine($"Message: {ex.Message}");
    Console.WriteLine($"StackTrace: {ex.StackTrace}");
    Console.WriteLine($"InnerException: {ex.InnerException?.Message ?? "(null)"}");
}

static void ProcessarSaque(Conta conta, decimal valor)
{
    try
    {
        conta.Sacar(valor);
    }
    catch (Exception ex)
    {
        throw new ApplicationException("Falha ao processar operacao de saque.", ex);
    }
}
