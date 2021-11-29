using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TrendsMobileAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AdsController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] {"this", "is", "hard", "coded"};
    }
  }
}