using System;

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

                int first = i;
                int last = sizeX - first - 1;

                for (int element = first; element< last;element++) {
                    
                    int offset = element - first;


                    int top = matrix[first, element];
                    int right = matrix[element,last];
                    int bottom = matrix[last, last-offset];
                    int left = matrix[last-offset, first];

                    matrix[first, element] = left;
                    matrix[element, last] = top;
                    matrix[last, last-offset] = right;
                    matrix[last-offset, first] = bottom;
                }
            }
            return matrix;
        }
    }
}
