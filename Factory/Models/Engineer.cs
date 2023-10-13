using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    // We didn't learn this but I was able to find a solution by myself. We learnt about empty fields but not invalid values.
    // Prompt - I should not be able to create an engineer or a machine if the form's fields are empty or contain INVALID VALUES.
    [Required]
    [RegularExpression("^[a-zA-Z][a-zA-Z0-9]*$", ErrorMessage = "The engineer's name can't be empty and it can only be alphabetic!")]
    public string Name { get; set; }

    [Required]
    [RegularExpression("Beginner|Intermediate|Expert", ErrorMessage = "Please provide an experience level, it can be one of the three level ('Beginner', 'Intermediate', 'Expert').")]
    public string Experience { get; set; }

    public List<Repair> JoinEntities { get; } // collection navigation property.
  }
}