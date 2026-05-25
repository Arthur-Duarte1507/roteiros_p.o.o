using AppExcecoesEx03;

Conta origem = new("001", 1_000m);
Conta destino = new("002", 200m);

try
{
    origem.Transferir(destino, 400m);
    Console.WriteLine("Transferencia concluida com sucesso.");
}
catch (Exception ex)
{
    Console.WriteLine($"Falha na transferencia: {ex.Message}");
}

Console.WriteLine($"Saldo origem: {origem.Saldo:0.00}");
Console.WriteLine($"Saldo destino: {destino.Saldo:0.00}");
