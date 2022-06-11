using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data.Repositorios.Interfaces
{
    public interface IRepositorioProduto : IRepositorioBase<Produto>
    {
         public List<Produto> BuscarProdutoComVendedor();
         public void AlterarValor(int id, double valor);
    }
}