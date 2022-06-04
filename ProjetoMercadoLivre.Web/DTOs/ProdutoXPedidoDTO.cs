using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.DTOs
{
    public class ProdutoXPedidoDTO
    {
        public int IdPxp { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public Produto? Produto { get; set; }
        public Pedido? Pedido { get; set; }
    }
}