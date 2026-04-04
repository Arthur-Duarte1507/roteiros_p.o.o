using BibliotecaFinanceira;

Console.WriteLine("Exercicio 6 - BibliotecaFinanceira");

var calculadora = new CalculadoraJuros();
double juros = calculadora.JurosSimples(capital: 1000, taxa: 0.02, tempo: 6);
Console.WriteLine($"Juros simples: {juros:F2}");

// A linha abaixo nao compila fora do assembly da DLL porque o metodo e internal.
// double total = calculadora.CalculoInterno(1000, 0.02, 6);
