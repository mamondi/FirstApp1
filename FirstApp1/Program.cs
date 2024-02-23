using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("Enter a number(1-100): ");
    int num = Convert.ToInt32(Console.ReadLine());
        if (num < 1 || num > 100)
        {
        Console.WriteLine("The number is not in the range of 1 to 100");
    }
        else if (num % 3 == 0)
        {
        Console.WriteLine("Fizz");
    }
        else if (num % 5 == 0)
        {
        Console.WriteLine("Buzz");
    }
        else if (num % 3 == 0 && num % 5 == 0)
        {
        Console.WriteLine("FizzBuzz");
    }
        else
        {
            Console.WriteLine(num);
        }
    }
}
