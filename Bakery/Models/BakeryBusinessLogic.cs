using System;
using System.Collections.Generic;

namespace BakeryStoreFront.Models
{
  public class Goods
  {
    private static Dictionary<string, int> _goodsPricing = new Dictionary<string, int>() 
    {
      {"bread", 5},
      {"pastry", 2},
    };

    
  }
}