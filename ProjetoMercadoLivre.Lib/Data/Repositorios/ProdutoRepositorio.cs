using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>
    {
        public ProdutoRepositorio(ProjetoMLContext context) : base(context, context.Produtos)
        {

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