using BibliotecaConversaoV2;
using System.Globalization;

Console.WriteLine("Exercicio 3 - Conversao de moeda");

double valor = LerDouble("Digite o valor de origem: ");
double taxa = LerDouble("Digite a taxa de cambio: ");

double convertido = ConversorV2.ConverterMoeda(valor, taxa);

Console.WriteLine($"Valor convertido: {convertido:F2}");

static double LerDouble(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);
        string? entrada = Console.ReadLine();

        if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out double valor))
        {
            return valor;
        }

        if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.GetCultureInfo("pt-BR"), out valor))
        {
            return valor;
        }

        Console.WriteLine("Entrada invalida. Tente novamente.");
    }
}
