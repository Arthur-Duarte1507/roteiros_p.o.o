using System.Xml.Linq;

string caminho = Path.Combine(AppContext.BaseDirectory, "estoque.xml");

if (!File.Exists(caminho))
{
    throw new FileNotFoundException("Arquivo estoque.xml nao encontrado.", caminho);
}

XDocument doc = XDocument.Load(caminho);

XElement? itemMouse = doc
    .Descendants("item")
    .FirstOrDefault(item =>
        string.Equals((string?)item.Element("nome"), "Mouse", StringComparison.OrdinalIgnoreCase));

if (itemMouse is null)
{
    throw new InvalidOperationException("Item Mouse nao encontrado no XML.");
}

XElement? quantidade = itemMouse.Element("quantidade");
if (quantidade is null)
{
    itemMouse.Add(new XElement("quantidade", "10"));
}
else
{
    quantidade.Value = "10";
}

doc.Save(caminho);

Console.WriteLine("XML atualizado com sucesso:");
Console.WriteLine(File.ReadAllText(caminho));
