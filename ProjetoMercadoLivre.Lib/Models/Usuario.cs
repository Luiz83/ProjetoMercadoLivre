using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMercadoLivre.Lib.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string  Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public List<Pedido> ListaPedidos { get; set; }
    }
}