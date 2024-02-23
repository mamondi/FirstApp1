using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        int formNum = 0;

        for(int i = 0; i <= 3; i++)
        {
            Console.WriteLine("Введіть цифру: ");
            int digit = Convert.ToInt32(Console.ReadLine());
            formNum = formNum * 10 + digit;
        }
        Console.WriteLine("Ваше число: ");
        Console.WriteLine(formNum);
    }
}
