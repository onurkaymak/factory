namespace Factory.Models
{
  public class Repair //Join entity
  {
    public int RepairId { get; set; }
    public int EngineerId { get; set; }
    public int MachineId { get; set; }
    public Engineer Engineer { get; set; } // reference navigation property
    public Machine Machine { get; set; } // reference navigation property
  }
}