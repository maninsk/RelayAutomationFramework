using NUnit.Framework;
using RestBDDAutomationPack;
using RestBDDAutomationPack.Helper;
using System.Net;

namespace TestExecution
{
    public class Tests
    {
        public HttpStatusCode statuscode;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPayouts()
        {

            var api = new Actions();
            var JsonHelper = new Helper();
            var res = api.GetPayouts();
            
            Assert.AreEqual(2, res.numberOfPayouts,"No of payout not matched with actual");
            Assert.AreEqual(JsonHelper.GetTestDataString("id"), res.payouts[0].id, "Payout id not matched with actual");
            Assert.AreEqual(JsonHelper.GetTestDataString("date"), res.payouts[0].date, "Payout date is  not matched with actual");
            Assert.AreEqual(JsonHelper.GetTestDataString("currency"), res.payouts[1].currency, "Payout currencyis  not matched with actual");

        }

        [Test]
        public void CreatePet()
        {
            
        }

        [Test]
        public void CreatePetUsingPut()
        {

        }

        [Test]
        public void DeletePet()
        {

            
        }
    }
}