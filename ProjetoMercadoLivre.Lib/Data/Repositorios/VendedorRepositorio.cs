using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class VendedorRepositorio : RepositorioBase<Vendedor>
    {
        public VendedorRepositorio(ProjetoMLContext context) : base(context, context.Vendedores)
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