using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMissingSmallestServices.Tests {
    [TestClass]
    public class FindMissingSmallestServicesTests {
        private FindMissingSmallestServices _services;
        public FindMissingSmallestServicesTests () {
            _services = new FindMissingSmallestServices ();
        }

        [DataTestMethod]
        [DataRow (2, new int[] { 1, 3, 5 })]
        [DataRow (4, new int[] { 1, 3, 5, 7, 9 })]
        [DataRow (7, new int[] { 9, 3, 2, 3, 11 })]
        [DataRow (15, new int[] { 1, 4, 6, 8, 12, 21 })]
        [DataRow (15, new int[] { 1, 4, 6, 8, 12, 21, 22 })]
        public void DummyTest (int value1, int[] value2) {
            Assert.AreEqual (value1, _services.FindMissing (value2).Count);

        }
    }
}