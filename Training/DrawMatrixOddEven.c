**Non-optimized**
static void DrawSquareOddOrEven()
        {
            int size = 5;

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (size % 2 == 0)//even
                    {
                        if (size / 2 == j || ((size / 2) + 1 == j) || i == (size / 2) || i == (size / 2) + 1)
                        {
                            Console.Write("1\t");
                        }
                        else
                        {
                            Console.Write("0\t");
                        }
                    }
                    else //odd
                    {
                        if (((size / 2) + 1 == j) || i == (size / 2) + 1)
                        {
                            Console.Write("1\t");
                        }
                        else
                        {
                            Console.Write("0\t");
                        }
                    }
                }
                Console.WriteLine();
            }
        }


**Optimized**
static void DrawSquareOddOrEven()
        {
            int size = 3;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == size/2 || j == size/2) || (size % 2 == 0 && (j == (size /2) -1 || i == (size/2) - 1)))
                    {
                        Console.Write("1\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }
                }
                Console.WriteLine();
            }

        }
       
**Output**
Even Matrix
0       1       1       0
1       1       1       1
1       1       1       1
0       1       1       0

Odd matrix
0       0       1       0       0
0       0       1       0       0
1       1       1       1       1
0       0       1       0       0
0       0       1       0       0
