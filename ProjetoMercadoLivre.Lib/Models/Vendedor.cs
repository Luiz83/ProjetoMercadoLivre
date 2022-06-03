namespace ProjetoMercadoLivre.Lib.Models
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Produto> ListaProdutos { get; set; }
    }
}