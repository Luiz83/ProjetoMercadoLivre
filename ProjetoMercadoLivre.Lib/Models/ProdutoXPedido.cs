namespace ProjetoMercadoLivre.Lib.Models
{
    public class ProdutoXPedido
    {
        public int IdPxp { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public Produto? Produto { get; set; }
        public Pedido? Pedido { get; set; }

        public ProdutoXPedido()
        {

        }

        public ProdutoXPedido(int idPxp,int idProduto, int idPedido, Produto produto, Pedido pedido)
        {
            IdPxp = idPxp;
            IdProduto = idProduto;
            IdPedido = idPedido;
            Produto = produto;
            Pedido = pedido;
        }
        
    }
}