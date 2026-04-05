using AulaTestes;

namespace AulaTestes.Tests;

public class Exercicio0Tests
{
    [Fact]
    public void Somar_DeveRetornar5()
    {
        var calc = new Calculadora();
        var resultado = calc.Somar(2, 3);

        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Dividir_DeveLancarExcecao()
    {
        var calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
    }

    [Fact]
    public void Carrinho_DeveEstarVazio()
    {
        var carrinho = new Carrinho();

        Assert.Empty(carrinho.Itens);
    }

    [Fact]
    public void Classificar_DeveRetornarPesoNormal()
    {
        var calc = new CalculadoraIMC();
        var resultado = calc.Classificar(22);

        Assert.Equal("Peso normal", resultado);
    }
}
