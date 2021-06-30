using System.ComponentModel.DataAnnotations;
using System;
namespace _022_crudelicious.Models
{
  public class Dish
  {
    [Key] // the below prop is the primary key, [Key] is not needed if named with pattern: ModelNameId
    public int DishId { get; set; }

    [Required]
    [MinLength(3)]
    public string Name { get; set; }


    [Required]
    [MinLength(3)]
    public string Chef { get; set; }


    [Required]
    public int Tastiness { get; set; }

    [Required]
    [Range(0, 10000)]
    public int Calories { get; set; }

    [Required]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
