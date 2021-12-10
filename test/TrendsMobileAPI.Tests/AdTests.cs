using System;
using Xunit;
using TrendsMobileAPI.Models;

namespace TrendsMobileAPI.Tests
{
  public class AdTests : IDisposable
  {
    Ad testAd;
    public AdTests()
    {
      testAd = new Ad 
      {
        Type = "Type",
        Model = "Model"
      };
    }

    public void Dispose()
    {
      testAd = null;
    }

    [Fact]
    public void CanChangeType()
    {
      // Arrange
      
      // Act
      testAd.Type = "Truck";
      // Assert 
      Assert.Equal("Truck", testAd.Type);
    }

    [Fact]
    public void CanChangeModel()
    {
      // Arange

      // Act
      testAd.Model = "Another Model";
      // Assert
      Assert.Equal("Another Model", testAd.Model);
    }
  }
}