using AppExcecoesEx08;

Conta conta = new("001", 2_000m);

try
{
    conta.Sacar(400m);
    conta.Sacar(400m);
    conta.Sacar(300m);
}
catch (LimiteSaqueDiarioException ex)
{
    Console.WriteLine($"Falha: {ex.Message}");
}

Console.WriteLine($"Saldo atual: {conta.Saldo:0.00}");
Console.WriteLine($"Total sacado no dia: {conta.TotalSacadoNoDia:0.00}");
