using Microsoft.EntityFrameworkCore;

namespace IndustrailEquipment.Models
{
  public class IndustrailEquipmentContext : DbContext
  {
    public IndustrailEquipmentContext(DbContextOptions<IndustrailEquipmentContext>options)
    : base(options)
    {

    }

    public DbSet<Machine> Machines { get; set; }
  }
}