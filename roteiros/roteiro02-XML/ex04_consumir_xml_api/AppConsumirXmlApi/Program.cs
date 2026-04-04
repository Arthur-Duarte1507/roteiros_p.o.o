using System.Xml.Linq;
using AppConsumirXmlApi;

string url = "https://www.w3schools.com/xml/simple.xml";

using HttpClient client = new();
string response = await client.GetStringAsync(url);
XDocument doc = XDocument.Parse(response);

List<Food> foods = doc
    .Descendants("food")
    .Select(food => new Food
    {
        Nome = (string?)food.Element("name") ?? "(sem nome)",
        Preco = (string?)food.Element("price") ?? "(sem preco)"
    })
    .ToList();

Console.WriteLine("Itens do XML da API:");
foreach (Food food in foods)
{
    Console.WriteLine($"Nome: {food.Nome} | Preco: {food.Preco}");
}
