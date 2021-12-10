using System.ComponentModel.DataAnnotations;

namespace TrendsMobileAPI.Dtos
{
  public class AdCreateDto
  {
    [Required]
    [MaxLength(250)]
    public string Type { get; set; }

    [Required]
    public string Model { get; set; }
  }
}