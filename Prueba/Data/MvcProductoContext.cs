using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class MvcProductoContext : DbContext
    {
        public MvcProductoContext(DbContextOptions<MvcProductoContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Producto { get; set; }
    }
}
