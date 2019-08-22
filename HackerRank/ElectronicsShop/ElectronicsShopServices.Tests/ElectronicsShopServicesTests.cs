using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicsShopServices.Tests
{
    [TestClass]
    public class ElectronicsShopServicesTests
    {
        private ElectronicsShopServices _services;

        public ElectronicsShopServicesTests(){
            _services = new ElectronicsShopServices();
        }
        [TestMethod]
        public void MoneySpentTest()
        {
            Assert.AreEqual(9,_services.GetMoneySpent(new int[]{3,1}, new int[]{5,2,8},10));
        }
    }
}
