using AulaTestes;

namespace AulaTestes.Tests;

public class CarrinhoTests
{
    [Fact]
    public void AdicionarItens_DeveSomarTotalCorretamente()
    {
        var carrinho = new Carrinho();

        carrinho.Adicionar(new Item { Nome = "Mouse", Preco = 100.0 });
        carrinho.Adicionar(new Item { Nome = "Teclado", Preco = 200.0 });

        Assert.Equal(300.0, carrinho.Total(), 2);
    }

    [Fact]
    public void Limpar_DeveZerarCarrinho()
    {
        var carrinho = new Carrinho();
        carrinho.Adicionar(new Item { Nome = "Mouse", Preco = 100.0 });

        carrinho.Limpar();

        Assert.Equal(0, carrinho.Quantidade());
        Assert.Equal(0.0, carrinho.Total(), 2);
        Assert.Empty(carrinho.Itens);
    }

    [Fact]
    public void Quantidade_DeveRetornarNumeroCorretoDeItens()
    {
        var carrinho = new Carrinho();

        carrinho.Adicionar(new Item { Nome = "Item 1", Preco = 10.0 });
        carrinho.Adicionar(new Item { Nome = "Item 2", Preco = 20.0 });
        carrinho.Adicionar(new Item { Nome = "Item 3", Preco = 30.0 });

        Assert.Equal(3, carrinho.Quantidade());
    }
}
