using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShopServices {
    public class ElectronicsShopServices {
        public int GetMoneySpent (int[] keyboards, int[] drives, int b) {

            List<int> arr = new List<int> { };

            for (int i = 0; i < keyboards.Length; i++) {
                for (int x = 0; x < drives.Length; x++) {
                    if (keyboards[i] + drives[x] <= b)
                        arr.Add (keyboards[i] + drives[x]);
                }
            }

            if (arr.Count == 0)
                return -1;
            else
                return arr.Max();
        }
    }
}