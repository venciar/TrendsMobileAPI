using System.Collections.Generic;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Data
{
  public interface ITrendsMobileAPIRepo {
    bool SaveChanges();
    IEnumerable<Ad> GetAllAds();
    Ad GetAdById(int id);
    void CreateAd(Ad ad);
    void UpdateAd(Ad ad);
    void DeleteAd(Ad ad);
  }
}
