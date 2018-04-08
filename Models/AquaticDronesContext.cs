using Microsoft.EntityFrameworkCore;

namespace AquaticDroneUI.Models
{
    public class AquaticDronesContext : DbContext
    {
        public AquaticDronesContext (DbContextOptions<AquaticDronesContext> options)
            : base(options)
        {
        }

        public DbSet<AquaticDroneUI.Models.AquaticDrones> AquaticDrones { get; set; }
    }
}
