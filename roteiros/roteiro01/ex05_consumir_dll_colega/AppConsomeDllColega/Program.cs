using BibliotecaColegaExemplo;

Console.WriteLine("Exercicio 5 - Consumo de DLL de colega (simulado)");

double mediaAritmetica = CalculadoraMedia.Aritmetica(7.5, 8.0, 9.0, 6.5);
double mediaPonderada = CalculadoraMedia.Ponderada(8.0, 2.0, 6.0, 1.0);

Console.WriteLine($"Media aritmetica: {mediaAritmetica:F2}");
Console.WriteLine($"Media ponderada: {mediaPonderada:F2}");
