using ControledeContatos.Data;
using ControledeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControledeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext()
        {
        }

        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }

        public DbSet<ContatoModel> Contatos { get; set; }

      
    }
}


