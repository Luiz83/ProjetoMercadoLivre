namespace ProjetoMercadoLivre.Lib.Models
{
    public class ProdutoXPedido : ModelBase
    {
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public Produto? Produto { get; set; }
        public Pedido? Pedido { get; set; }

        public ProdutoXPedido()
        {

        }

        public ProdutoXPedido(int idPxp,int idProduto, int idPedido)
        {
            Id = idPxp;
            IdProduto = idProduto;
            IdPedido = idPedido;
        }
        
    }
}