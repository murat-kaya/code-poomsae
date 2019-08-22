using System;

namespace CountingValleysServices {
    public class CountingValleysServices {

        public int CountValleys (int n, string s) {

            char[] arr;
            int count = 0;

            arr = s.ToCharArray ();
            int level = 0;
            int pos = 0;
            for (int i = 0; i < n; i++) {

                if (arr[i].ToString () == "U") {
                    level++;
                    pos = 1;
                } else {
                    level--;
                    pos = -1;
                }
                if (level == 0 && pos == 1)
                    count++;
            }

            return count;
        }
    }
}