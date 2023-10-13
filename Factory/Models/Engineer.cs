using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }

    [Required(ErrorMessage = "The engineer's name can't be empty!")] // validation attribute for Name.
    public string Name { get; set; }

    [Required(ErrorMessage = "Please provide an experience level! ('Beginner', 'Intermediate', 'Expert')")] // validation attribute for Experience.
    public string Experience { get; set; }

    public List<Repair> JoinEntities { get; } // collection navigation property.
  }
}