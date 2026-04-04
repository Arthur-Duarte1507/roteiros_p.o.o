using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

string caminho = Path.Combine(AppContext.BaseDirectory, "configuracao.json");

if (!File.Exists(caminho))
{
    throw new FileNotFoundException("Arquivo configuracao.json nao encontrado.", caminho);
}

JObject config = JObject.Parse(File.ReadAllText(caminho));
int portaAnterior = config.Value<int>("Porta");

config["Porta"] = 5432;
File.WriteAllText(caminho, config.ToString(Formatting.Indented));

Console.WriteLine($"Porta anterior: {portaAnterior}");
Console.WriteLine($"Porta nova: {config.Value<int>("Porta")}");
Console.WriteLine("JSON atualizado:");
Console.WriteLine(config.ToString(Formatting.Indented));
