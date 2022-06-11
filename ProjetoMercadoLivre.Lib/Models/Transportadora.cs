namespace ProjetoMercadoLivre.Lib.Models
{
    public class Transportadora : ModelBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Pedido> ListaPedidos { get; set; } = new List<Pedido>();

        public Transportadora()
        {

        }

        public Transportadora(int idTransportadora,string nome, string telefone, string email)
        {
            Id = idTransportadora;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}