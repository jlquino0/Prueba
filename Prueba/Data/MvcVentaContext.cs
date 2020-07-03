using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class MvcVentaContext : DbContext
    {
        public MvcVentaContext(DbContextOptions<MvcVentaContext> options)
            : base(options)
        {
        }

        public DbSet<Venta> Venta { get; set; }
    }
}