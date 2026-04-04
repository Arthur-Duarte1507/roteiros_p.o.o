namespace BibliotecaFinanceira;

public class CalculadoraJuros
{
    public double JurosSimples(double capital, double taxa, double tempo)
    {
        ValidarNaoNegativo(capital, nameof(capital));
        ValidarNaoNegativo(taxa, nameof(taxa));
        ValidarNaoNegativo(tempo, nameof(tempo));

        return capital * taxa * tempo;
    }

    internal double CalculoInterno(double capital, double taxa, double tempo)
    {
        return capital + JurosSimples(capital, taxa, tempo);
    }

    private static void ValidarNaoNegativo(double valor, string parametro)
    {
        if (valor < 0)
        {
            throw new ArgumentOutOfRangeException(parametro, "O valor nao pode ser negativo.");
        }
    }
}
