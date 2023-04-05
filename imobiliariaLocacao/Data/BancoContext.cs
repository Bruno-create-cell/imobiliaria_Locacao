using imobiliariaLocacao.Models;
using Microsoft.EntityFrameworkCore;

namespace imobiliariaLocacao.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contato { get; set; }
    }
}
