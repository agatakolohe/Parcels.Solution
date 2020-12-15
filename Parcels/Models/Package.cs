using System.Collections.Generic;

namespace Parcels.Models
{
    public class Package
    {
      public int Length { get; set; }
      public int Height { get; set; }
      public int Width { get; set; }
      public int Weight { get; set; }
      public int Volume { get; set; }
      public int ShippingPrice { get; set; } = 3;

      public Package (int length, int height, int width, int weight)
      {
        Length = length;
        Height = height;
        Width = width;
        Weight = weight;
      }
      
      public void GetVolume()
      {
          int volume = Length * Height * Width;
          this.Volume = volume;
      }

      public int CostToShip()
      {
          return (Volume + Weight) * ShippingPrice;
      }
    }
}