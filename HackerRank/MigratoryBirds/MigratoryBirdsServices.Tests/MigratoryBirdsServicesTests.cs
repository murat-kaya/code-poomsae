using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MigratoryBirdsServices.Tests
{
    [TestClass]
    public class MigratoryBirdsServicesTests
    {

        private readonly MigratoryBirdsServices _services;
        public MigratoryBirdsServicesTests(){
            _services = new MigratoryBirdsServices();
        }

        [TestMethod]
        public void FakeTest()
        {
            //List<int> numbers = new List<int>{1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4};
            List<int> numbers = new List<int>{1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4};
            //List<int> numbers = new List<int>{5,1,3,3,3,2,3,5,4,1,1,5,2,1,4,5,4,3,2,2,5,4,1,3,4,2,3,4,3,1,1,5,3,3,5,3,5,5,1,1,2,1,5,2,5,3,5,1,1,5,2,2,5,2,2,5,1,5,1,4,4,5,2,1,1,4,5,4,4,3,3,5,1,4,2,4,3,4,1,1,5,1,1,3,1,3,4,5,3,1,2,4,2,5,1,4,5,1,5,5,5,1,3,3,3,2,3,5,4,1,1,5,2,1,4,5,4,3,2,2,5,4,1,3,4,2,3,4,3,1,1,5,3,3,5,3,5,5,1,1,2,1,5,2,5,3,5,1,1,5,2,2,5,2,2,5,1,5,1,4,4,5,2,1,1,4,5,4,4,3,3,5,1,4,2,4,3,4,1,1,5,1,1,3,1,3,4,5,3,1,2,4,2,5,1,4,5,1,5,5};
            
            Assert.AreEqual(3,_services.GroupOfBirds(numbers));
        }
    }
}
