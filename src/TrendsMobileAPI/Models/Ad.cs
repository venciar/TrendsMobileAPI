using System.ComponentModel.DataAnnotations;

namespace TrendsMobileAPI.Models
{
  public class Ad
  { [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public string Type { get; set; }
  }
}