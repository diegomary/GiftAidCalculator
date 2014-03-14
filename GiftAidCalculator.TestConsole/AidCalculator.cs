using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GiftAidCalculator.TestConsole.Helpers;
using GiftAidCalculator.TestConsole.Repository;

namespace GiftAidCalculator.TestConsole
{
    public static  class AidCalculator
    {
      private static decimal _donationamount;
      private static decimal _currenttaxrate;
      private static string _charityevent;
      public static decimal DonationAmount
      {
          get 
          { 
              return _donationamount;
          }
          set
          {
              _donationamount = value;
          }
      }
      public static decimal CurrentTaxRate
      {
          get
          {
              return _currenttaxrate;
          }
          set
          {
              _currenttaxrate = value;
          }
      }
      public static string CharityEvent
      {
          get
          {
              return _charityevent;
          }
          set
          {
              _charityevent = value;
          }
      }  
      public static decimal GiftAidAmount()
      {
              var isWithEvent =new SupplementsRepository().GetAllSupplements().Where(m=>m.CharityEvent.Equals(_charityevent)).FirstOrDefault();
              if(isWithEvent!=null)
              {
                  decimal supplement = isWithEvent.Supplement;
                  var gaRatio = _currenttaxrate / (100 - _currenttaxrate);
                  return Rounder.RoundToPenny(_donationamount * gaRatio * supplement, 2);
              }
              else
              {
                  var gaRatio = _currenttaxrate / (100 - _currenttaxrate);
                  return Rounder.RoundToPenny(_donationamount * gaRatio, 2);
              }         
               
      }

    }
}
