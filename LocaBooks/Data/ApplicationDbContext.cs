using LocaBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace LocaBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }

        public DbSet<LocacaoModel> Locacoes { get;  set; }
        public DbSet<LivroModel> Livros { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}
