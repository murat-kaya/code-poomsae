using System;
using Xunit;

namespace HangingPostersServices.Tests {
    public class HangingPostersServicesTests {
        private HangingPostersServices _services;

        public HangingPostersServicesTests () {
            _services = new HangingPostersServices ();
        }

        [Theory]
        [InlineData (10, new int[] { 151, 92, 131, 165, 197, 30, 149, 199, 19, 85 }, new int[] { 13, 15, 26, 12, 11, 22, 11, 35, 23, 21 }, 185)] //130
        public void FindLadderSize (int h, int[] wallPoints, int[] lengths, int equality) {
            Assert.Equal (equality, _services.Solution (h, wallPoints, lengths));
        }
    }
}