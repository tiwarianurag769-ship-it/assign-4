using System;

class Q1
{
    public delegate void CalculateSum(int a, int b);

    public static void Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Sum = " + result);
    }

    static void Main2()
    {
        CalculateSum d = Sum;

        d(10, 20);
    }
}