using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required(ErrorMessage = "The machine's name can't be empty!")] // validation attribute for Name.
    public string Name { get; set; }

    [Required(ErrorMessage = "Please provide an difficulty level! ('Easy', 'Medium', 'Hard')")] // validation attribute for RepairDifficulty.
    public string RepairDifficulty { get; set; }
  }
}