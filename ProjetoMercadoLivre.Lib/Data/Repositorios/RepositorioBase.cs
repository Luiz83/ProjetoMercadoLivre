using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interfaces;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class RepositorioBase<T> :IRepositorioBase<T> where T : ModelBase 
    {
        protected readonly ProjetoMLContext _context;
        protected readonly DbSet<T> _dbset;

        public RepositorioBase(ProjetoMLContext context, DbSet<T> dbset = null)
        {
            _context = context;
            _dbset = dbset;
        }

        public List<T> BuscarTodos()
        {
            return _dbset.AsNoTracking().ToList();
        }
        public T BuscarPorId(int id)
        {
            return _dbset.Find(id);
        }
        public void Adicionar(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            var item = _dbset.Find(id);
            _dbset.Remove(item);
            _context.SaveChanges();
        }



    }
}