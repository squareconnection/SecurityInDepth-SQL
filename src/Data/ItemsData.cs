using Microsoft.EntityFrameworkCore;

namespace SecurityInDepth.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext (DbContextOptions<ItemsContext> options)
            : base(options)
        {
        }

        public DbSet<SecurityInDepth.Models.Item> Item { get; set; }
    }
}