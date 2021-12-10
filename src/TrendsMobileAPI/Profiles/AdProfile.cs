using AutoMapper;
using TrendsMobileAPI.Dtos;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Prfiles
{
  public class AdProfile : Profile
  {
    public AdProfile() 
    {
      CreateMap<Ad, AdReadDto>();
      CreateMap<AdCreateDto, Ad>();
    }
  }
}
