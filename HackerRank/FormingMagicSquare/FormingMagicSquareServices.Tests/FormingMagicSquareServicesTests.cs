using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormingMagicSquareServices.Tests
{
    [TestClass]
    public class FormingMagicSquareServicesTests
    {
        private FormingMagicSquareServices _services;
        public FormingMagicSquareServicesTests(){
            _services = new FormingMagicSquareServices();
        }
        [TestMethod]
        public void FakeTest()
        {
           /*
            5 3 4
            1 5 8  
            6 4 2
           */

            int[,] badSquare = new int[3,3]{{5,3,4},{1,5,8},{6,4,2}};
            int[,] initSquare =new int[3,3]{{4,9,2},{3,5,7},{8,1,6}};


for(var i = 0; i < badSquare.Length; i++) {    
     //has O(n) time complexity   
      for(var j = 0; j < badSquare.Length; j++) { 
          //has O(n^2) time complexity      
          // More loops?    
          }}
        }
    }
}
