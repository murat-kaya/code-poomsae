using System.Linq;

namespace SockMerchantServices {
    public class SockMerchantServices {
        public int FindNumberOfPairs (int[] arr) {

            arr = arr.OrderBy (o => o).ToArray ();
            int counter = 0;
            for (int i = 0; i < arr.Length - 1; i++) {

                if (arr[i] == arr[i + 1]) {
                    arr[i] = 0;
                    arr[i + 1] = 0;
                    counter++;
                }
            }
            return counter;
        }
    }
}