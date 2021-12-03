using System.Linq;
using System.Collections.Generic;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Data {
  public class TrendsMobileAPIRepo : ITrendsMobileAPIRepo
  {
    private readonly DataContext _context;

    public TrendsMobileAPIRepo(DataContext context) 
    {
      _context = context;
    }
    public void CreateAd(Ad ad)
    {
      throw new System.NotImplementedException();
    }

    public void DeleteAd(Ad ad)
    {
      throw new System.NotImplementedException();
    }

    public Ad GetAdById(int id)
    {
      return _context.AdItems.FirstOrDefault(p => p.Id == id);
    }

    public IEnumerable<Ad> GetAllAds()
    {
      return _context.AdItems.ToList();
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    public void UpdateAd(Ad ad)
    {
      throw new System.NotImplementedException();
    }
  }
}