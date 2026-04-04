namespace BibliotecaGeometria;

public static class CalculadoraArea
{
    public static double Retangulo(double largura, double altura)
    {
        ValidarPositivo(largura, nameof(largura));
        ValidarPositivo(altura, nameof(altura));

        return largura * altura;
    }

    public static double Triangulo(double baseTriangulo, double altura)
    {
        ValidarPositivo(baseTriangulo, nameof(baseTriangulo));
        ValidarPositivo(altura, nameof(altura));

        return (baseTriangulo * altura) / 2.0;
    }

    public static double Circulo(double raio)
    {
        ValidarPositivo(raio, nameof(raio));

        return Math.PI * raio * raio;
    }

    private static void ValidarPositivo(double valor, string parametro)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(parametro, "O valor deve ser maior que zero.");
        }
    }
}
