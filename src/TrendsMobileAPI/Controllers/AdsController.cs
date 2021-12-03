using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrendsMobileAPI.Data;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AdsController : ControllerBase
  {
    private readonly ITrendsMobileAPIRepo _repository;

    public AdsController(ITrendsMobileAPIRepo repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Ad>> GetAllAds()
    {
      var ads = _repository.GetAllAds();

      return Ok(ads);
    }

    [HttpGet("{id}")]
    public ActionResult<Ad> GetAdById(int id)
    {
      var adItem = _repository.GetAdById(id);
      if(adItem == null)
      {
        return NotFound();
      }
      return Ok(adItem);
    }
  }
}