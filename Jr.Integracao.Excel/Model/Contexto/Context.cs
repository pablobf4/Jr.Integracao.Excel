using Jr.Integracao.Excel.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace Jr.Integracao.Excel.Model.Contexto
{
    public class Context : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server = NOME_DO_SERVIDOR_SQL; Database=NOME_DO_BANCO; Trusted_Connection=True; TrustServerCertificate = True;");
        }
    }

}
