using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();

        bool test = (num % 2) == 1;

        if (test)
        {
            Console.Write("Even");
        }
        else
        {
            Console.Write("Odd");
        }
    }
}
