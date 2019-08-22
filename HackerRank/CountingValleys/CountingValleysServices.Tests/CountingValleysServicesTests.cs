using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingValleysServices.Tests
{
    [TestClass]
    public class CountingValleysServicesTests
    {

        private CountingValleysServices _services;

        public CountingValleysServicesTests(){
            _services = new CountingValleysServices();
        }
        [TestMethod]
        public void FindValleysCountTest()
        {
            Assert.AreEqual(1,_services.CountValleys(8,"UDDDUDUU"));
        }
    }
}
