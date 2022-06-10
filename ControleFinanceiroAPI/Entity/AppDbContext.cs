using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiroAPI.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
   
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
           

        //}

        public DbSet<RecebimentoPagameto> RecebimentosPagamentos { get; set; }

       
    }
}