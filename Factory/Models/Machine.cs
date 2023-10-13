using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    [Required]
    [RegularExpression("^[a-zA-Z][a-zA-Z0-9]*$", ErrorMessage = "The machine's name can't be empty and it can only be alphabetic!")]
    public string Name { get; set; }

    [Required]
    [RegularExpression("Easy|Medium|Hard", ErrorMessage = "Please provide an experience level, it can be one of the three level Please provide an difficulty level! ('Easy', 'Medium', 'Hard').")]
    public string RepairDifficulty { get; set; }

    public List<Repair> JoinEntities { get; } // collection navigation property.
  }
}