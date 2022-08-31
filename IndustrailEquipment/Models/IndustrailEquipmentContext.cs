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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Machine>()
        .HasData(
          new Machine{ MachineId = 1, Hours = 302, Name = "AGV_01", SerialNumber = "2867654", Status = "Running"},
          new Machine{ MachineId = 2, Hours = 246, Name = "AGV_02", SerialNumber = "2658392", Status = "Faulted"},
          new Machine{ MachineId = 3, Hours = 432, Name = "AGV_03", SerialNumber = "9867232", Status = "Idle"},
          new Machine{ MachineId = 4, Hours = 654, Name = "AGV_04", SerialNumber = "2837892", Status = "Running"},
          new Machine{ MachineId = 5, Hours = 123, Name = "AGV_05", SerialNumber = "2839404", Status = "Running"}
        );
    }
  }
}