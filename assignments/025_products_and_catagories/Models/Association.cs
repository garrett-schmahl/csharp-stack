using System.ComponentModel.DataAnnotations;

namespace _025_products_and_catagories.Models
{
  public class Association
  {

    [Key]
    public int AssociationID { get; set; }

    public int CategoryID { get; set; }
    public Category Category { get; set; }
    public int ProductID { get; set; }
    public Product Product { get; set; }
  }
}