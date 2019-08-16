using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SockMerchantServices.Tests
{
    [TestClass]
    public class SockMerchantServicesTests
    {
        private SockMerchantServices _services;

        public SockMerchantServicesTests(){

            _services = new SockMerchantServices();
        }
        [TestMethod]
        public void FindPairsTest()
        {
            int[] arr = {10,20,20,10,10,30,50,10,20};

            Assert.AreEqual(3,_services.FindNumberOfPairs(arr));
        }
    }
}
