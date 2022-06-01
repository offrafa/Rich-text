using Microsoft.EntityFrameworkCore;
using Rich_text.Models;

namespace Rich_text.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TextoModel> Textos { get; set; }
    }
}
