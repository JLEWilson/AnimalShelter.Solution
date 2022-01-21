using System.ComponentModel.DataAnnotations;
using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    [StringLength(20)]
    [MinLength(2)]
    public string Species { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime ArrivalDate { get; set; }
    [Required]
    [Range(0, 30, ErrorMessage = "Age must be between 0 and 30.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
  }
}