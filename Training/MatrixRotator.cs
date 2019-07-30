using System;
using System.Linq;

namespace ArrayRotate {
    public class Program {
        // Driver function 
        public static void Main (string[] args) {
            int[, ] matrix5x5 = { { 0, 1, 2, 3, 4 },
                { 5, 6, 7, 8, 9 },
                { 10, 11, 12, 13, 14 },
                { 15, 16, 17, 18, 19 },
                { 20, 21, 22, 23, 24 }
            };

            int[, ] matrix3x3 = { { 0, 1, 2 },
                { 3, 4, 5 },
                { 6, 7, 8 }
            };

            

            Console.WriteLine ("Print without rotating");
            print_matrix (matrix5x5);
            Console.WriteLine ("--------------------------------------");
            Console.WriteLine ("Print after rotating");
            print_matrix (rotmatrix (matrix5x5));
        }

        static void print_matrix (int[, ] matrix) {
            int i = 0;
            foreach (int row in matrix) {

                if (i % matrix.GetLength (0) == 0) {
                    Console.WriteLine ();
                }
                Console.Write (row + "\t");
                i++;
            }
            Console.WriteLine ();
        }

        static int[, ] rotmatrix (int[, ] matrix) {
            int sizeX = matrix.GetLength (0);
            int sizeY = matrix.GetLength (1);
            int layerCount = 0;
            if (sizeX == sizeY) {
                layerCount = sizeX / 2;
            }

            for (int i = 0; i < layerCount; i++) {

                int first = i;//0
                int last = sizeX - first - 1;//2

                for (int element = first; element< last;element++) {
                    
                    int offset = element - first;


                    int top = matrix[first, element];       // 0,0 // 0,1 // 0,2 // 0,3 // 0,4
                    matrix[element, last] = top;            // 0,4 // 1,4 // 2,4 // 3,4 // 4,4
                    
                    int right = matrix[element,last];       // 0,4 // 1,4 // 2,4 // 3,4 // 4,4
                    matrix[last, last-offset] = right;      // 4,4 // 4,3 // 4,2 // 4,1 // 4,0

                    int bottom = matrix[last, last-offset]; // 4,4 // 4,3 // 4,2 // 4,1 // 4,0
                    matrix[last-offset, first] = bottom;    // 4,0 // 3,0 // 2,0 // 1,0 // 0,0

                    int left = matrix[last-offset, first];  // 4,0 // 3,0 // 2,0 // 1,0 // 0,0
                    matrix[first, element] = left;          // 0,0 // 0,1 // 0,2 // 0,3 // 0,4

                }
            }
            return matrix;
        }
    }
}