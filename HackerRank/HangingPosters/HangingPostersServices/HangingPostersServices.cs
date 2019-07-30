using System;

namespace HangingPostersServices {
    public class HangingPostersServices {
        public int Solution (int h, int[] wallPoints, int[] lengths) {

            int max = 0;
            for (int i = 0; i < wallPoints.Length; i++) {
                double absLenOfp = wallPoints[i] + lengths[i] / 4.0;
                double absLenOfm = lengths[i] / 2.0;
                double totalLen = absLenOfp - absLenOfm;

                if (Convert.ToInt32 (totalLen - h) > max) {
                    max = Convert.ToInt32 (Math.Ceiling (totalLen - h));
                }
            }
            return max;
        }
    }
}