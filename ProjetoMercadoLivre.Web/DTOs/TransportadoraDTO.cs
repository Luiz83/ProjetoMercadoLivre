using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Web.DTOs
{
    public class TransportadoraDTO
    {
        public int IdTransportadora { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}