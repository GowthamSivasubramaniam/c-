

using System.ComponentModel.DataAnnotations;
namespace E_commerce.Models
{
public class Commodities

{
    [Key]
    public int Id { get; set;}
    [Required]
   public string? Name { get; set; }
    public int Price { get; set;}
}
}