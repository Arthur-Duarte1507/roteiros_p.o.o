using System.Text.Json;
using AppListaCarros;

List<Carro> carros =
[
    new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2022 },
    new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2021 },
    new Carro { Marca = "Volkswagen", Modelo = "Golf", Ano = 2020 }
];

JsonSerializerOptions options = new()
{
    WriteIndented = true
};

string caminho = Path.Combine(AppContext.BaseDirectory, "carros.json");
File.WriteAllText(caminho, JsonSerializer.Serialize(carros, options));

string jsonLido = File.ReadAllText(caminho);
List<Carro>? carrosLidos = JsonSerializer.Deserialize<List<Carro>>(jsonLido);

if (carrosLidos is null)
{
    throw new InvalidOperationException("Falha ao desserializar carros.json.");
}

Console.WriteLine("Lista de carros lida do JSON:");
foreach (Carro carro in carrosLidos)
{
    Console.WriteLine($"Marca: {carro.Marca} | Modelo: {carro.Modelo} | Ano: {carro.Ano}");
}
