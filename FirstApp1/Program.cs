using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a percentage");
        int percent = Convert.ToInt32(Console.ReadLine());

        int result = (num * percent) / 100;
        Console.WriteLine("The result is: " + result);
        
    }   
}