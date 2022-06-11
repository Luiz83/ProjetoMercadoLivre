namespace ProjetoMercadoLivre.Lib.Models
{
    public class Produto : ModelBase
    {
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public Vendedor? Vendedor { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }

        public Produto()
        {

        }

        public Produto(int idProduto,int idVendedor, string nome, string descricao,Double valor, DateTime dataCadastro)
        {
            Id = idProduto;
            IdVendedor = idVendedor;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = dataCadastro;
        }
    }
}