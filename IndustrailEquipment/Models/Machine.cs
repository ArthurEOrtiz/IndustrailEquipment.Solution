using System;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace IndustrailEquipment.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public int Hours { get; set; } 
    public string Status { get; set; }
    
  }


}
