using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>
    {
        public UsuarioRepositorio(ProjetoMLContext context) : base(context, context.Usuarios)
        {

        }
        public void AlterarSenha(int id, string senha)
        {
            var item = _dbset.Find(id);
            item.Senha = senha;
            _context.SaveChanges();
        }
    }
}