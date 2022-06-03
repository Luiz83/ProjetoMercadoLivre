namespace ProjetoMercadoLivre.Lib.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public Vendedor? Vendedor { get; set; }
        public int IdVendedor { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }
    }
}