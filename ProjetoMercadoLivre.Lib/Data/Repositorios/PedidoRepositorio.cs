using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios
{
    public class PedidoRepositorio : RepositorioBase<Pedido>
    {
        public PedidoRepositorio(ProjetoMLContext context) : base(context, context.Pedidos)
        {

        }
        public void AlterarStatus(int id, string status)
        {
            var item = _dbset.Find(id);
            item.StatusPedido = status;
            _context.SaveChanges();
        }
    }
}