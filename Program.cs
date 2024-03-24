using System.Globalization;

class Program
{
    static void Main()
    {
        //Question1();
        //Question2();
        //Question3();
        //Question4();
        //Question5();
        //Question6();
        //Question7();
        //Question8();
        Question9();
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

    public static void Question6()
    {
        Console.WriteLine("Question 6");
        int sumOfSquares = 0;
        int sumOfNumbers = 0;
        int squareOfSum = 0;
        for (int i = 1; i<=100; i++)
        {
            sumOfSquares += i * i;
        }
        Console.WriteLine("Sum of squares = " +  sumOfSquares);

        for (int i= 1; i<=100; i++)
        {
            sumOfNumbers += i;
        }
        squareOfSum = sumOfNumbers*sumOfNumbers;
        Console.WriteLine("Square of sum = " + squareOfSum);

        Console.WriteLine("Difference = " + (squareOfSum - sumOfSquares));
    }

    public static void Question7()
    {
        Console.WriteLine("Question 7");
        int count;
        int primeCount = 0;
        int threshold = 10001;
        int targetPrime = 0;
        // generate prime numbers
        for (int i = 1; i >= 1; i++)
        {
            count = 0;
            for (int j = 1; j<=i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                    //break;
                }
            }
            //Console.WriteLine(count);
            if (count == 2)
            {
                primeCount++;
                if (primeCount == threshold)
                {
                    targetPrime = i;
                    break;
                }
                //Console.WriteLine("Prime " + primeCount + " = " + i);
            }
        }
        Console.WriteLine(primeCount + "st prime number is " + targetPrime);
    }

    public static void Question8()
    {
        Console.WriteLine("Question 8");
        string num = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";

        string subStr;
        char[] arr;

        int digitCount = 13;

        double product = 1;

        double largestProduct = 0;
        string largestProductAdjacentDigits = "";

        for (int i=0; i<(num.Length - digitCount); i++)
        {
            product = 1;
            subStr = num.Substring(i, digitCount);
            arr = subStr.ToCharArray();

            foreach (char c in arr)
            {
                //Console.WriteLine(char.GetNumericValue(c));
                product *= char.GetNumericValue(c);
                //Console.WriteLine(c);
                //Console.WriteLine(product);
            }
            if (product > largestProduct)
            {
                //Console.WriteLine(true);
                largestProduct = product;
                largestProductAdjacentDigits = subStr;
            }
        }
        Console.WriteLine("largest Product 4 Adjacent Digits = " + largestProductAdjacentDigits);
        Console.WriteLine("largestProduct = " + largestProduct);
    }
    public static void Question9()
    {
        Console.WriteLine("Question 9");

        int sumOfSquares;
        int sumOfTriplet;

        for (int i=1; i<500; i++)
        {
            for (int j=i+1; j<500; j++)
            {
                sumOfSquares =  Square(i) + Square(j);
                for (int k=j+1; k<500; k++)
                {
                    //Console.WriteLine(Square(k));
                    if (sumOfSquares == Square(k))
                    {
                        sumOfTriplet = i + j + k;
                        if (sumOfTriplet == 1000)
                        {
                            Console.WriteLine("The pythagorean triplet whose sum equals 1000 is " + i + ", " + j + ", " + k);
                            Console.WriteLine("Product of the pythagorean triplet = " + (i * j * k));
                        }
                    }
                }
            }
        }
    }
    public static int Square(int num)
    {
        return num * num;
    }
}