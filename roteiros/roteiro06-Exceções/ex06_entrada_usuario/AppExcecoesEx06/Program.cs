using System.Globalization;

Console.Write("Digite um valor para deposito: ");
string? entrada = Console.ReadLine();

try
{
    if (string.IsNullOrWhiteSpace(entrada))
    {
        throw new FormatException("Entrada vazia.");
    }

    decimal valor = decimal.Parse(entrada, CultureInfo.CurrentCulture);
    Console.WriteLine($"Valor convertido com sucesso: {valor:0.00}");
}
catch (FormatException)
{
    Console.WriteLine("Entrada invalida. Digite apenas numeros (ex: 150,50).\n");
}
catch (OverflowException)
{
    Console.WriteLine("Valor muito grande ou muito pequeno para conversao decimal.\n");
}
