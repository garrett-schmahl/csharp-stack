using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _025_products_and_catagories.Models
{
  public class Category
  {
    [Key]
    public int CategoryID { get; set; }


    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    [Display(Name = "Name")]
    public string Name { get; set; }

    public List<Association> Associations { get; set; }

    [Display(Name = "Product")]
    [NotMapped]
    public int ProductID { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}