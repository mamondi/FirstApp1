using System;

class matimatika
{
    static void Main()
    {
        double num, sum = 0, max, min, product = 1;

        Console.Write("Введіть число 1: ");
        num = Convert.ToDouble(Console.ReadLine());
        max = num;
        min = num;
        sum += num;
        product *= num;


        for (int i = 2; i <= 5; i++)
        {
            Console.Write($"Введіть число {i}: ");
            num = Convert.ToDouble(Console.ReadLine());
            sum += num;
            product *= num;

            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine($"Сума: {sum}");
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Мінімум: {min}");
        Console.WriteLine($"Добуток: {product}");
    }
}