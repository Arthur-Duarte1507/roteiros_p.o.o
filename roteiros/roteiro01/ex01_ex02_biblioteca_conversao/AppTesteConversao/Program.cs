using BibliotecaConversao;

Console.WriteLine("Exercicio 1 e 2 - BibliotecaConversao");

double celsius = 25;
double fahrenheit = Conversor.CelsiusParaFahrenheit(celsius);
Console.WriteLine($"{celsius} C = {fahrenheit:F2} F");

double metros = 1530;
double quilometros = Conversor.MetrosParaQuilometros(metros);
Console.WriteLine($"{metros} m = {quilometros:F3} km");
