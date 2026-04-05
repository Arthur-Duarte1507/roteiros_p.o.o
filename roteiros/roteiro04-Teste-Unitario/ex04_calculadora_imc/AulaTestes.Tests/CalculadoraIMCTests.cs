using AulaTestes;

namespace AulaTestes.Tests;

public class CalculadoraIMCTests
{
    [Fact]
    public void Calcular_DeveRetornarImcEsperado()
    {
        var calc = new CalculadoraIMC();

        Assert.Equal(22.86, calc.Calcular(70, 1.75), 2);
    }

    [Fact]
    public void Classificar_17_DeveRetornarAbaixoDoPeso()
    {
        var calc = new CalculadoraIMC();

        Assert.Equal("Abaixo do peso", calc.Classificar(17));
    }

    [Fact]
    public void Classificar_26_DeveRetornarSobrepeso()
    {
        var calc = new CalculadoraIMC();

        Assert.Equal("Sobrepeso", calc.Classificar(26));
    }

    [Fact]
    public void Calcular_AlturaMenorOuIgualZero_DeveLancarExcecao()
    {
        var calc = new CalculadoraIMC();

        Assert.Throws<ArgumentException>(() => calc.Calcular(70, 0));
    }
}
