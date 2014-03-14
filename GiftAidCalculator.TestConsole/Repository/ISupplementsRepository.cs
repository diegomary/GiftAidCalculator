using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiftAidCalculator.TestConsole.Helpers;

namespace GiftAidCalculator.TestConsole.Repository
{
 public  interface ISupplementsRepository
    {
      List<SupplementToGiftAid> GetAllSupplements();
    }
}
