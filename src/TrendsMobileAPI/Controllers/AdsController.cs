using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrendsMobileAPI.Data;
using TrendsMobileAPI.Models;
using AutoMapper;
using TrendsMobileAPI.Dtos;

namespace TrendsMobileAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AdsController : ControllerBase
  {
    private readonly IAdRepo _repository;
    private readonly IMapper _mapper;

    public AdsController(IAdRepo repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Ad>> GetAllAds()
    {
      var adItems = _repository.GetAllAds();

      return Ok(_mapper.Map<IEnumerable<AdReadDto>>(adItems));
    }

    [HttpGet("{id}", Name="GetAdById")]
    public ActionResult<Ad> GetAdById(int id)
    {
      var adItem = _repository.GetAdById(id);
      if(adItem == null)
      {
        return NotFound();
      }
      return Ok(_mapper.Map<AdReadDto>(adItem));
    }

    [HttpPost]
    public ActionResult<AdReadDto> CreateAd(AdCreateDto adCreateDto)
    {
      var adModel = _mapper.Map<Ad>(adCreateDto);

      _repository.CreateAd(adModel);
      _repository.SaveChanges();

      var adReadDto = _mapper.Map<AdReadDto>(adModel);
      return CreatedAtRoute(nameof(GetAdById), new { Id = adReadDto.Id }, adReadDto);
    }
  }
}