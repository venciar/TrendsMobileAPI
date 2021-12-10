using System;
using System.Linq;
using System.Collections.Generic;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Data {
  public class AdRepo : IAdRepo
  {
    private readonly DataContext _context;

    public AdRepo(DataContext context) 
    {
      _context = context;
    }
    public void CreateAd(Ad ad)
    {
      if(ad == null)
      {
        throw new ArgumentNullException(nameof(ad));
      }
      _context.AdItems.Add(ad);
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
      return (_context.SaveChanges() >= 0);
    }

    public void UpdateAd(Ad ad)
    {
      throw new System.NotImplementedException();
    }
  }
}