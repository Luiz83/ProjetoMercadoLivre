namespace ProjetoMercadoLivre.Lib.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
        public Transportadora Transportadora { get; set; }
        public Usuario Cliente { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }
    }
}