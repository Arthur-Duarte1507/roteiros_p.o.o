using System.Text.Json;
using AppDesserializacaoAluno;

string caminho = Path.Combine(AppContext.BaseDirectory, "aluno.json");

if (!File.Exists(caminho))
{
    throw new FileNotFoundException("Arquivo aluno.json nao encontrado.", caminho);
}

string json = File.ReadAllText(caminho);
Aluno? aluno = JsonSerializer.Deserialize<Aluno>(json);

if (aluno is null)
{
    throw new InvalidOperationException("Falha ao desserializar aluno.json.");
}

Console.WriteLine($"Nome: {aluno.Nome}");
Console.WriteLine($"Idade: {aluno.Idade}");
Console.WriteLine($"Curso: {aluno.Curso}");
