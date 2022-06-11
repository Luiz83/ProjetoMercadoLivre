namespace ProjetoMercadoLivre.Lib.Models
{
    public class Vendedor : ModelBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();

        public Vendedor()
        {

        }

        public Vendedor(int idVendedor,string nome, string email, string cnpj, DateTime dataCadastro)
        {
            Id = idVendedor;
            Nome = nome;
            Email = email;
            Cnpj = cnpj;
            DataCadastro = dataCadastro;
        }
    }
}