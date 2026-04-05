namespace AulaTestes;

public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }

        return a / b;
    }
}
