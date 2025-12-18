using JSDeposito.Application.DTOs;

public class CarrinhoService
{
    public List<ItemCarrinho> Itens { get; } = new();

    public event Action? OnChange;

    public void Adicionar(ProdutoDto produto)
    {
        var item = Itens.FirstOrDefault(i => i.Produto.Id == produto.Id);

        if (item is null)
            Itens.Add(new ItemCarrinho(produto));
        else
            item.Incrementar();

        OnChange?.Invoke();
    }

    public decimal Total => Itens.Sum(i => i.Subtotal);

}
