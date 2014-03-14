using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit;
using GiftAidCalculator.TestConsole;
using GiftAidCalculator.TestConsole.Repository;
using GiftAidCalculator.TestConsole.Helpers;
using Moq;

namespace GiftAidCalculator.Tests
{   
    [TestFixture]    
    class TestClass
    {
        [Test]
        public void TestTaxRateCurrentRate()
        {
            AidCalculator.DonationAmount = 100.00m;
            AidCalculator.CurrentTaxRate = 20m;
            AidCalculator.GiftAidAmount();
            Assert.AreEqual(Rounder.RoundToPenny(AidCalculator.GiftAidAmount(),2), 25);
        }

        [Test]
        public void CalculateGiftAmountWithTaxRateAndAmountFromDataStore()
        {
            var repo = new Mock<IRepository>();
            repo.Setup(x => x.GetTaxRate()).Returns(20);
            repo.Setup(x => x.GetAmount()).Returns(100);
            var service = repo.Object;
            AidCalculator.DonationAmount = service.GetAmount();
            AidCalculator.CurrentTaxRate = service.GetTaxRate();           
            Assert.AreEqual(Rounder.RoundToPenny(AidCalculator.GiftAidAmount(),2), 25);
        }

        [Test]
        public void TestRounderClass()
        { 
            Assert.AreEqual(Rounder.RoundToPenny(1.316m, 2), 1.32m);
        }

        [Test]
        public void TestCorrectlyRoundedGiftAmount()
        {        
            AidCalculator.DonationAmount = 100.00m;
            AidCalculator.CurrentTaxRate = 17.5m;        
            Assert.AreEqual(Rounder.RoundToPenny(AidCalculator.GiftAidAmount(), 2), 21.21m);
        }


        [Test]
        public void TestTaxRateCurrentRateWithSwimmingEvent()
        {
            AidCalculator.DonationAmount = 100.00m;
            AidCalculator.CurrentTaxRate = 20m;
            AidCalculator.CharityEvent = "swimming";
            AidCalculator.GiftAidAmount();
            Assert.AreEqual(Rounder.RoundToPenny(AidCalculator.GiftAidAmount(), 2), 25.75);
        }


        [Test]
        public void TestTaxRateCurrentRateWithRunningEvent()
        {
            AidCalculator.DonationAmount = 100.00m;
            AidCalculator.CurrentTaxRate = 20m;
            AidCalculator.CharityEvent = "running";
            AidCalculator.GiftAidAmount();
            Assert.AreEqual(Rounder.RoundToPenny(AidCalculator.GiftAidAmount(), 2), 26.25);
        }






    }
}
