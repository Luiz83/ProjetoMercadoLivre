namespace ProjetoMercadoLivre.Lib.Models
{
    public class Pedido : ModelBase
    {
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public Transportadora? Transportadora { get; set; }
        public Usuario? Cliente { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; } = new List<ProdutoXPedido>();

        public Pedido()
        {

        }

        public Pedido(int idPedido, int idTransportadora, int idUsuario, DateTime dataPedido, string statusPedido)
        {
            Id = idPedido;
            IdTransportadora = idTransportadora;
            IdUsuario = idUsuario;
            DataPedido = dataPedido;
            StatusPedido = statusPedido;
        }
    }
}