using Microsoft.EntityFrameworkCore;

namespace SenacFoods
{
    public class ComandaDBContext : DbContext
    {
        //1-construtor do banco de dados
        public ComandaDBContext() : base()
        {
            
        }
        //2-configurar a conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 2.1 String de Conexão
            var conexao = "Server=localhost;Database=SenacFoods;User=root;Password=";

            // 2.2 Configurar o provedor de banco de dados
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cardapioitem> Cardapioitems { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaItem> ComandaItems { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }
    }
}