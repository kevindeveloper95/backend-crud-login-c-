using crud_login.Model;
using Microsoft.EntityFrameworkCore;

namespace crud_login
    
{
    public class AplicationDbContext: DbContext
    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
    }
}
