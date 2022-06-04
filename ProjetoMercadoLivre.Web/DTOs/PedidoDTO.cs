using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.DTOs
{
    public class PedidoDTO
    {
        public int IdPedido { get; set; }
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public Transportadora? Transportadora { get; set; }
        public Usuario? Cliente { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }
    }
}