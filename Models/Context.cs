using Microsoft.EntityFrameworkCore;

namespace TCC_Novo.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "Server=localhost;DataBase=ProjetoIntegrador;Uid=root;",
                new MySqlServerVersion(new Version(10, 4, 24))
            );
        }

        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}