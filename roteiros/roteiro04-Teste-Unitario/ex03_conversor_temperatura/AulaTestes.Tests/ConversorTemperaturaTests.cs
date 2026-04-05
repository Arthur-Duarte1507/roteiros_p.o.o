using AulaTestes;

namespace AulaTestes.Tests;

public class ConversorTemperaturaTests
{
    [Fact]
    public void CelsiusParaFahrenheit_ZeroDeveRetornar32()
    {
        var conversor = new ConversorTemperatura();

        Assert.Equal(32, conversor.CelsiusParaFahrenheit(0), 2);
    }

    [Fact]
    public void CelsiusParaFahrenheit_CemDeveRetornar212()
    {
        var conversor = new ConversorTemperatura();

        Assert.Equal(212, conversor.CelsiusParaFahrenheit(100), 2);
    }

    [Fact]
    public void FahrenheitParaCelsius_32DeveRetornar0()
    {
        var conversor = new ConversorTemperatura();

        Assert.Equal(0, conversor.FahrenheitParaCelsius(32), 2);
    }

    [Fact]
    public void FahrenheitParaCelsius_212DeveRetornar100()
    {
        var conversor = new ConversorTemperatura();

        Assert.Equal(100, conversor.FahrenheitParaCelsius(212), 2);
    }
}
