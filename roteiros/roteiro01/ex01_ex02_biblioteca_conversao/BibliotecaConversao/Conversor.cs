namespace BibliotecaConversao;

public static class Conversor
{
    public static double CelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 9.0 / 5.0) + 32.0;
    }

    public static double MetrosParaQuilometros(double metros)
    {
        return metros / 1000.0;
    }
}
