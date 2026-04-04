using System.Xml.Linq;

string caminho = Path.Combine(AppContext.BaseDirectory, "alunos.xml");

if (!File.Exists(caminho))
{
    throw new FileNotFoundException("Arquivo alunos.xml nao encontrado.", caminho);
}

XDocument doc = XDocument.Load(caminho);
IEnumerable<XElement> alunos = doc.Root?.Elements("aluno") ?? Enumerable.Empty<XElement>();

Console.WriteLine("Alunos encontrados no XML:");
foreach (XElement aluno in alunos)
{
    string nome = (string?)aluno.Element("nome") ?? "(sem nome)";
    string curso = (string?)aluno.Element("curso") ?? "(sem curso)";

    Console.WriteLine($"Nome: {nome} | Curso: {curso}");
}
