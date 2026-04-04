using System.Xml.Serialization;
using AppCriarSalvarXml;

List<Produto> produtos =
[
    new Produto { Nome = "Notebook", Preco = 4500.00 },
    new Produto { Nome = "Mouse", Preco = 120.50 },
    new Produto { Nome = "Teclado", Preco = 230.90 }
];

string caminho = Path.Combine(AppContext.BaseDirectory, "produtos.xml");
XmlSerializer serializer = new(typeof(List<Produto>));

using (FileStream fs = File.Create(caminho))
{
    serializer.Serialize(fs, produtos);
}

string xmlGerado = File.ReadAllText(caminho);

Console.WriteLine($"Arquivo salvo: {caminho}");
Console.WriteLine("Conteudo gerado:");
Console.WriteLine(xmlGerado);
