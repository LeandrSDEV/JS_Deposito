using JSDeposito.Application.DTOs;

public class ItemCarrinho
{
    public ProdutoDto Produto { get; }
    public int Quantidade { get; private set; } = 1;

    public decimal Subtotal => Produto.Preco * Quantidade;

    public ItemCarrinho(ProdutoDto produto)
    {
        Produto = produto;
    }

    public void Incrementar()
    {
        Quantidade++;
    }
}
