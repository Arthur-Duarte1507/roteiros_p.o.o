using AppExcecoesEx02;

Conta conta = new("001", 1_200m);

try
{
    conta.Sacar(600m);
}
catch (LimiteDiarioException ex)
{
    Console.WriteLine($"Falha no saque: {ex.Message}");
}

conta.Sacar(300m);
Console.WriteLine($"Saldo final: {conta.Saldo:0.00}");
