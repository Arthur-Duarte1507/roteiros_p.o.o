namespace AulaTestes;

public class Item
{
    public string Nome { get; set; } = string.Empty;
    public double Preco { get; set; }
}

public class Carrinho
{
    private readonly List<Item> items = [];

    public IReadOnlyCollection<Item> Itens => items;

    public void Adicionar(Item item)
    {
        items.Add(item);
    }

    public double Total()
    {
        return items.Sum(i => i.Preco);
    }

    public int Quantidade()
    {
        return items.Count;
    }

    public void Limpar()
    {
        items.Clear();
    }
}
