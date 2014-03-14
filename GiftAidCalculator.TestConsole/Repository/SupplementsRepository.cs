using GiftAidCalculator.TestConsole.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole.Repository
{
  public  class SupplementsRepository : ISupplementsRepository
    {
        public List<SupplementToGiftAid> GetAllSupplements()
        {
            List<SupplementToGiftAid> allsupplements = new List<SupplementToGiftAid>();
            allsupplements.Add(new SupplementToGiftAid { CharityEvent = "running", Supplement  =  1.05m });
            allsupplements.Add(new SupplementToGiftAid { CharityEvent = "swimming", Supplement = 1.03m });
            return allsupplements;
        }
    }
}
