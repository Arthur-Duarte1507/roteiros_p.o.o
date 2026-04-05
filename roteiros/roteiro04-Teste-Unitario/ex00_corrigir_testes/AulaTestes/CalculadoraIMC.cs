namespace AulaTestes;

public class CalculadoraIMC
{
    public string Classificar(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }

        if (imc < 25)
        {
            return "Peso normal";
        }

        if (imc < 30)
        {
            return "Sobrepeso";
        }

        return "Obesidade";
    }
}
