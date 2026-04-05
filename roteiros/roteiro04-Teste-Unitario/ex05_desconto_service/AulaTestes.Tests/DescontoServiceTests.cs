using AulaTestes;

namespace AulaTestes.Tests;

public class DescontoServiceTests
{
    [Theory]
    [InlineData(100, 10, 90)]
    [InlineData(200, 50, 100)]
    [InlineData(80, 0, 80)]
    public void AplicarDesconto_ValoresValidos_DeveRetornarResultadoEsperado(double valor, double percentual, double esperado)
    {
        var service = new DescontoService();

        var resultado = service.AplicarDesconto(valor, percentual);

        Assert.Equal(esperado, resultado, 2);
    }

    [Fact]
    public void AplicarDesconto_ValorNegativo_DeveLancarExcecao()
    {
        var service = new DescontoService();

        Assert.Throws<ArgumentException>(() => service.AplicarDesconto(-1, 10));
    }

    [Fact]
    public void AplicarDesconto_PercentualMenorQueZero_DeveLancarExcecao()
    {
        var service = new DescontoService();

        Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, -1));
    }

    [Fact]
    public void AplicarDesconto_PercentualMaiorQueCem_DeveLancarExcecao()
    {
        var service = new DescontoService();

        Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, 101));
    }
}
