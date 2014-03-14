using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole.Repository
{
  public interface IRepository
    {
        decimal GetTaxRate();
        decimal GetAmount();

    }
}
