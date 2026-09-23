using System;

class Q3
{
    public delegate void Calculator(int a, int b);

    public static void Addition(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    public static void Subtraction(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    public static void Multiplication(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    public static void Division(int a, int b)
    {
        Console.WriteLine("Division = " + (a / b));
    }

    static void Main3()
    {
        Calculator c = Addition;
        c += Subtraction;
        c += Multiplication;
        c += Division;

        c(20, 10);
    }
}
