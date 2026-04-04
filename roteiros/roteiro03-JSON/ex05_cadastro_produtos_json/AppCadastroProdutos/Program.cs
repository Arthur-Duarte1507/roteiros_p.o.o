using System.Globalization;
using AppCadastroProdutos;
using Newtonsoft.Json;

List<Produto> produtos =
[
    new Produto
    {
        Id = 1,
        Nome = "Notebook",
        Preco = 4500.00,
        Estoque = 10,
        Fornecedor = "Tech Supply",
        CodigoInterno = "NBK-INT-001"
    },
    new Produto
    {
        Id = 2,
        Nome = "Mouse",
        Preco = 120.50,
        Estoque = 45,
        Fornecedor = "Perifericos BR",
        CodigoInterno = "MSE-INT-002"
    },
    new Produto
    {
        Id = 3,
        Nome = "Teclado",
        Preco = 230.90,
        Estoque = 22,
        Fornecedor = null,
        CodigoInterno = "TCL-INT-003"
    }
];

JsonSerializerSettings settings = new()
{
    Formatting = Formatting.Indented,
    NullValueHandling = NullValueHandling.Ignore
};

string caminho = Path.Combine(AppContext.BaseDirectory, "produtos.json");
string json = JsonConvert.SerializeObject(produtos, settings);
File.WriteAllText(caminho, json);

Console.WriteLine($"Arquivo salvo: {caminho}");
Console.WriteLine("JSON gerado:");
Console.WriteLine(json);

List<Produto>? produtosLidos = JsonConvert.DeserializeObject<List<Produto>>(File.ReadAllText(caminho));
if (produtosLidos is null)
{
    throw new InvalidOperationException("Falha ao desserializar produtos.json.");
}

Console.WriteLine("Produtos desserializados:");
foreach (Produto produto in produtosLidos)
{
    Console.WriteLine(
        $"Id: {produto.Id} | Nome: {produto.Nome} | Preco: {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)} | Estoque: {produto.Estoque} | Fornecedor: {produto.Fornecedor ?? "(null)"}");
}

string jsonInvalido =
    """
    {
      "Id": 99,
      "Estoque": 3,
      "Fornecedor": "Fornecedor X"
    }
    """;

try
{
    _ = JsonConvert.DeserializeObject<Produto>(jsonInvalido);
    Console.WriteLine("ERRO: faltou validacao dos campos obrigatorios.");
}
catch (JsonSerializationException ex)
{
    Console.WriteLine("Validacao OK: Nome e Preco sao obrigatorios.");
    Console.WriteLine($"Mensagem da excecao: {ex.Message}");
}
