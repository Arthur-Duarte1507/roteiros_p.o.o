using AppExcecoesEx01;

Conta conta = new("001", 1_000m);

try
{
    conta.Depositar(15_000m);
}
catch (LimiteDepositoException ex)
{
    Console.WriteLine($"Falha no deposito: {ex.Message}");
}

conta.Depositar(500m);
Console.WriteLine($"Saldo final: {conta.Saldo:0.00}");
