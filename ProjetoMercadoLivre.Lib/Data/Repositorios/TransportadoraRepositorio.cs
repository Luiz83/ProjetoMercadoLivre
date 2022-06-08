using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class TransportadoraRepositorio : RepositorioBase<Transportadora>
    {
        public TransportadoraRepositorio(ProjetoMLContext context) : base(context, context.Transportadoras)
        {

        }
        public void AlterarEmail(int id, string email)
        {
            var item = _dbset.Find(id);
            item.Email = email;
            _context.SaveChanges();
        }
    }
}