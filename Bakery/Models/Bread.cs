using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadOrder { get; set; }

    public Bread(int order)
    {
      BreadOrder = order;
    }
    public int OrderTotal()
    {
      if (BreadOrder % 3 == 0)
      {
        int totalPrice = (BreadOrder - (BreadOrder / 3)) * 5;
        return totalPrice;
      }
      else if (BreadOrder >= 25)
      {
        return BreadOrder * 1;
      }
      else
      {
        return BreadOrder * 5;
      }
    }
  }
}