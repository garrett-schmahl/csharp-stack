using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _024_chef_and_dishes.Models
{
  public class Dish
  {
    [Key]
    public int DishId { get; set; }

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    [Display(Name = "Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "is required")]
    [Range(0, 15000)]
    [Display(Name = "Calories")]
    public int Calories { get; set; }

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Tastiness")]
    public int Tastiness { get; set; }

    [Required(ErrorMessage = "is required")]
    [MinLength(15, ErrorMessage = "must be at least 15 characters")]
    [Display(Name = "Description")]
    public string Description { get; set; }
    public int ChefId { get; set; }
    public Chef Chef { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}