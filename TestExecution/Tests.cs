using NUnit.Framework;
using RestBDDAutomationPack;
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
            var res = api.GetPayouts();
           // Assert.AreEqual(111, res.id,"Pet Id is not as expected");
            
            
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