using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class MvcClienteContext : DbContext
    {
        public MvcClienteContext(DbContextOptions<MvcClienteContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}