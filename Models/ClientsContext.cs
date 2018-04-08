using Microsoft.EntityFrameworkCore;

namespace AquaticDroneUI.Models
{
    public class ClientsContext : DbContext
    {
        public ClientsContext (DbContextOptions<ClientsContext> options)
            : base(options)
        {
        }

        public DbSet<AquaticDroneUI.Models.Clients> Clients { get; set; }
    }
}
