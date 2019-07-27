 static void SumPrimes()
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                int isPrime = 1;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = 0;
                    }
                }
                if (isPrime == 1)
                {
                    Console.WriteLine("prime found {0}", i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of prime numbers is {0}", sum);
        }
        
 **Output**

prime found 1
prime found 2
prime found 3
prime found 5
prime found 7
prime found 11
prime found 13
prime found 17
prime found 19
prime found 23
prime found 29
prime found 31
prime found 37
prime found 41
prime found 43
prime found 47
Sum of prime numbers is 329
 
