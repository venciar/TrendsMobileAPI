using System.Collections.Generic;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Data
{
  public class MockTrendsMobileAPIRepo : ITrendsMobileAPIRepo
  {
    void ITrendsMobileAPIRepo.CreateAd(Ad ad)
    {
      throw new System.NotImplementedException();
    }

    void ITrendsMobileAPIRepo.DeleteAd(Ad ad)
    {
      throw new System.NotImplementedException();
    }

    Ad ITrendsMobileAPIRepo.GetAdById(int id)
    {
      throw new System.NotImplementedException();
    }

    IEnumerable<Ad> ITrendsMobileAPIRepo.GetAllAds()
    {
      throw new System.NotImplementedException();
    }

    bool ITrendsMobileAPIRepo.SaveChanges()
    {
      throw new System.NotImplementedException();
    }

    void ITrendsMobileAPIRepo.UpdateAd(Ad ad)
    {
      throw new System.NotImplementedException();
    }
  }
}