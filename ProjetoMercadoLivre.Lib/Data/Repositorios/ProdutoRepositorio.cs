using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Data.Repositorios.Interfaces;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IRepositorioProduto 
    {
        private readonly ProjetoMLContext _context;
        public ProdutoRepositorio(ProjetoMLContext context) : base(context, context.Produtos)
        {
            _context = context;
        }
        public List<Produto> BuscarProdutoComVendedor()
        {
            return _dbset.AsNoTracking().Include(x => x.Vendedor).ToList();
        }
        public void AlterarValor(int id, double valor)
        {
            var item = _dbset.Find(id);
            item.Valor = valor;
            _context.SaveChanges();
        }
    }
}