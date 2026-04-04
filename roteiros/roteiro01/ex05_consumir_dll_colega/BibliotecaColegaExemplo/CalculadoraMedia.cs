namespace BibliotecaColegaExemplo;

public static class CalculadoraMedia
{
    public static double Aritmetica(params double[] valores)
    {
        if (valores is null || valores.Length == 0)
        {
            throw new ArgumentException("Informe ao menos um valor.", nameof(valores));
        }

        return valores.Average();
    }

    public static double Ponderada(double nota1, double peso1, double nota2, double peso2)
    {
        double somaPesos = peso1 + peso2;

        if (somaPesos <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(somaPesos), "A soma dos pesos deve ser maior que zero.");
        }

        return ((nota1 * peso1) + (nota2 * peso2)) / somaPesos;
    }
}
