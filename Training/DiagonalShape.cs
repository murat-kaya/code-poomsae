static void DiagonalShape()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ((i == j) || (i + j == 6))
                    {
                        Console.Write("▓");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

**Output**

▓   ▓
 ▓ ▓
  ▓
 ▓ ▓
▓   ▓

**Analysis**

(i,j)   1	   2	 3	 4	 5
  1	   1,1	1,2	1,3	1,4	1,5
  2	   2,1	2,2	2,3	2,4	2,5
  3	   3,1	3,2	3,3	3,4	3,5
  4	   4,1	4,2	4,3	4,4	4,5
  5	   5,1	5,2	5,3	5,4	5,5

**Formula**
i==j or i+j = 6
