using Microsoft.EntityFrameworkCore;
using ProjetoMercadoLivre.Lib.Models;

namespace ProjetoMercadoLivre.Lib.Data
{
    public class ProjetoMLContext : DbContext
    {
        public ProjetoMLContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Produto
            modelBuilder.Entity<Produto>().ToTable("ml_produtos");
            modelBuilder.Entity<Produto>().HasKey(x => x.Id);
            modelBuilder.Entity<Produto>().HasOne(x => x.Vendedor).WithMany(x => x.ListaProdutos).HasForeignKey(x => x.Vendedor);
            //Pedido
            modelBuilder.Entity<Pedido>().ToTable("ml_pedidos");
            modelBuilder.Entity<Pedido>().HasKey(x => x.Id);
            modelBuilder.Entity<Pedido>().HasOne(x => x.Transportadora).WithMany(x => x.ListaPedidos).HasForeignKey(x => x.Transportadora);
            modelBuilder.Entity<Pedido>().HasOne(x => x.Cliente).WithMany(x => x.ListaPedidos).HasForeignKey(x => x.Cliente);
            //ProdutoXPedido
            modelBuilder.Entity<ProdutoXPedido>().ToTable("ml_produtosxpedidos");
            modelBuilder.Entity<ProdutoXPedido>().HasKey(x => x.Id);
            modelBuilder.Entity<ProdutoXPedido>().HasOne(x => x.Produto).WithMany(x => x.ListaProdutosXPedidos).HasForeignKey(x => x.Produto);
            modelBuilder.Entity<ProdutoXPedido>().HasOne(x => x.Pedido).WithMany(x => x.ListaProdutosXPedidos).HasForeignKey(x => x.Pedido);
            //Transportadora
            modelBuilder.Entity<Transportadora>().ToTable("ml_transportadoras");
            modelBuilder.Entity<Transportadora>().HasKey(x => x.Id);
            modelBuilder.Entity<Transportadora>().HasMany(x => x.ListaPedidos).WithOne(x => x.Transportadora);
            //Vendedor
            modelBuilder.Entity<Vendedor>().ToTable("ml_vendedores");
            modelBuilder.Entity<Vendedor>().HasKey(x => x.Id);
            modelBuilder.Entity<Vendedor>().HasMany(x => x.ListaProdutos).WithOne(x => x.Vendedor);
            //Usuario
            modelBuilder.Entity<Usuario>().ToTable("ml_usuarios");
            modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
            modelBuilder.Entity<Usuario>().HasMany(x => x.ListaPedidos).WithOne(x => x.Cliente);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProdutoXPedido> ProdutosXPedidos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Transportadora> Transportadoras { get; set; }
    }
}