using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiftAidCalculator.TestConsole.Helpers
{
   public static class  Rounder
    {
       public static decimal RoundToPenny(decimal amount, int decplaces)
       {
           return Math.Round(amount, decplaces);
       }
    }
}
