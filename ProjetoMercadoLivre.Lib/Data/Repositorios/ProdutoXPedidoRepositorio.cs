using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class ProdutoXPedidoRepositorio : RepositorioBase<ProdutoXPedido>
    {
        public ProdutoXPedidoRepositorio(ProjetoMLContext context) : base(context, context.ProdutosXPedidos)
        {

        }
        public void AlterarProduto(int id, int idProduto)
        {
            var item = _dbset.Find(id);
            item.IdProduto = idProduto;
            _context.SaveChanges();
        }
    }
}