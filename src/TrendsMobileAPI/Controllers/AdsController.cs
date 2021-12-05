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
    private readonly ITrendsMobileAPIRepo _repository;
    private readonly IMapper _mapper;

    public AdsController(ITrendsMobileAPIRepo repository, IMapper mapper)
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

    [HttpGet("{id}")]
    public ActionResult<Ad> GetAdById(int id)
    {
      var adItem = _repository.GetAdById(id);
      if(adItem == null)
      {
        return NotFound();
      }
      return Ok(_mapper.Map<AdReadDto>(adItem));
    }
  }
}