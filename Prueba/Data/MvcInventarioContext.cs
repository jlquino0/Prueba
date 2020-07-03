using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class MvcInventarioContext : DbContext
    {
        public MvcInventarioContext(DbContextOptions<MvcInventarioContext> options)
            : base(options)
        {
        }

        public DbSet<Invenario> Inventario { get; set; }
    }
}