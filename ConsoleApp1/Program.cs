using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    
    public static bool IsFibonacci(int number)
    {
        if (number < 0)
            return false;

       
        int x1 = 5 * number * number + 4;
        int x2 = 5 * number * number - 4;

        return IsPerfectSquare(x1) || IsPerfectSquare(x2);
    }

    
    public static bool IsPerfectSquare(int n)
    {
        int sqrt = (int)Math.Sqrt(n);
        return n == sqrt * sqrt;
    }

    static void Main()
    {
        Random rand = new Random();
        List<int> numbers = new List<int>();
        List<int> primes = new List<int>();
        List<int> fibonacci = new List<int>();

        
        for (int i = 0; i < 100; i++)
        {
            numbers.Add(rand.Next(1, 1001));  
        }

        
        foreach (int number in numbers)
        {
            if (IsPrime(number))
                primes.Add(number);
            if (IsFibonacci(number))
                fibonacci.Add(number);
        }

        
        File.WriteAllLines("primes.txt", primes.ConvertAll(x => x.ToString()));
        File.WriteAllLines("fibonacci.txt", fibonacci.ConvertAll(x => x.ToString()));

        
        Console.WriteLine($"Общее количество чисел: 100");
        Console.WriteLine($"Простых чисел: {primes.Count}");
        Console.WriteLine($"Чисел Фибоначчи: {fibonacci.Count}");
        Console.WriteLine($"Чисел, которые являются и простыми, и числами Фибоначчи: {primes.FindAll(x => fibonacci.Contains(x)).Count}");
    }
}
