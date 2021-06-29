using System.ComponentModel.DataAnnotations;
namespace _020_Dojo_Survey_With_Model.Models
{
  public class Survey
  {
    [Required]
    [MinLength(2)]
    [Display(Name = "Name: ")]
    public string Name { get; set; }

    [Required]
    [Display(Name = "Dojo Location: ")]
    public string DojoLocation { get; set; }

    [Required]
    [Display(Name = "Favorite Language: ")]
    public string FavoriteLanguage { get; set; }

    [MinLength(20)]
    [Display(Name = "Comment: ")]
    public string Comment { get; set; }
  }
}