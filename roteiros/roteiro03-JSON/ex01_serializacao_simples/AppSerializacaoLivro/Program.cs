using System.Text.Json;
using AppSerializacaoLivro;

Livro livro = new()
{
    Titulo = "Clean Code",
    Autor = "Robert C. Martin",
    Ano = 2008
};

JsonSerializerOptions options = new()
{
    WriteIndented = true
};

string json = JsonSerializer.Serialize(livro, options);

Console.WriteLine("JSON do livro:");
Console.WriteLine(json);
