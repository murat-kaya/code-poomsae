using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DayOfTheProgrammerServices.Tests
{
    [TestClass]
    public class DayOfTheProgrammerServicesTests
    {
        private readonly DayOfTheProgrammerServices _services;
        public DayOfTheProgrammerServicesTests(){

            _services = new DayOfTheProgrammerServices();
        }
        [TestMethod]
        public void FakeTest()
        {
            Assert.AreEqual("12.09.1800",_services.FindDayOfProgrammer(1800));
            Assert.AreEqual("12.09.2016",_services.FindDayOfProgrammer(2016));
            Assert.AreEqual("13.09.2017",_services.FindDayOfProgrammer(2017));

        }
    }
}
