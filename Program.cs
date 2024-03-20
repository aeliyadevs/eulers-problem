class Program
{
    static void Main()
    {
        //Question1();
        //Question2();
        //Question3();
        //Question4();
        Question5();
    }

    public static void Question1()
    {
        Console.WriteLine("Question 1");

        int sum = 0;

        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }

    public static void Question2()
    {
        Console.WriteLine("Question 2");

        int a = 1;
        int b = 2;

        Stack<int> fibValues = new Stack<int>();
        fibValues.Push(a);
        fibValues.Push(b);

        int nextFibValue;

        while(fibValues.First() < 4000000)
        {
            nextFibValue = a + b;
            if (nextFibValue > 4000000)
            {
                break;
            }
            fibValues.Push(nextFibValue);
            a = b;
            b = nextFibValue;
        }

        //Console.WriteLine("Fibonacci Series - values not exceeding four million");
        //foreach (int value in fibValues)
        //{
        //    Console.WriteLine(value);
        //}

        Stack<int> evenValues = new Stack<int>();

        foreach (int value in fibValues)
        {
            if (value % 2 == 0)
            {
                evenValues.Push(value);
            }
        }

        //Console.WriteLine("Even values of the Fibonacci series");
        //foreach (int value in evenValues)
        //{
        //    Console.WriteLine(value);
        //}

        int sum = 0;
        foreach (int value in evenValues)
        {
            sum += value;
        }
        Console.WriteLine("Sum of even values: ");
        Console.WriteLine(sum);
    }

    public static void Question3()
    {
        Console.WriteLine("Question 3");
        long num = 600851475143;
        int largestPrimeFactor = 0;
        for (long i = 2; i < Math.Sqrt(600851475143); i++) // using squareroot of very large number for fast calculation
        {
            if (num % i == 0) // find the factors
            {
                
                //Console.WriteLine(i);
                int count = 0;

                for (long j = 2; j < i; j++) // separate prime factors
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                //Console.WriteLine(count);
                if (count == 0)
                {
                    //Console.WriteLine(i);
                    if (i > largestPrimeFactor)
                    {
                        largestPrimeFactor = (int)i;
                    }
                }
                // end - separate prime factors
            }
        }
        Console.WriteLine("Largest prime factor of 600851475143 is " + largestPrimeFactor);
    }

    public static void Question4()
    {
        int largestPalindrome = 0;
        Console.WriteLine("Question 4");
        //Console.WriteLine(IsPalindrome(95744759));
        for (int i = 999; i >= 100; i--)
        {
            for (int j = 999; j >= 100; j--)
            {
                //Console.WriteLine(j);
                //Console.WriteLine(IsPalindrome(i * j));
                if (IsPalindrome(i*j))
                {
                    if (i*j > largestPalindrome)
                    {
                        largestPalindrome = i * j;
                    }
                    //Console.WriteLine(i + " * " + j);
                }
            }
        }
        Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers is " + largestPalindrome);
    }

    public static bool IsPalindrome(int num)
    {
        bool status = true;
        string numToStr = num.ToString();

        for (int i = 0; i < numToStr.Length / 2; i++)
        {
            //Console.Write(i + " vs " + (numToStr.Length - (i + 1)) + " -> ");
            if (numToStr[i] == numToStr[numToStr.Length - (i + 1)])
            {
                //Console.WriteLine("match")
                status = true;
            }
            else
            {
                //Console.WriteLine("no match");
                status = false;
                break;
            }

        }
        return status;
    }

    public static void Question5()
    {
        Console.WriteLine("Question 5");

        int count;
        for (int i = 2520; i >= 2520; i+=20)
        {
            count = 0;
            for (int j = 1; j <= 20; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 20) {
                Console.WriteLine("Number evenly divisible by all the numbers from 1 to 20 is " + i);
                break;
            }
        }
    }
}