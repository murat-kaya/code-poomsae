using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingBookServices.Tests
{
    [TestClass]
    public class DrawingBookServicesTests
    {
        private DrawingBookServices _services;

        public DrawingBookServicesTests(){

            _services = new DrawingBookServices();
        }
        [TestMethod]
        public void FindTurnsTest()
        {
            Assert.AreEqual(1,_services.FindTurns(2,6));
        }
    }
}
