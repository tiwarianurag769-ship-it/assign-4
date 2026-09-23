using System;

class Q4
{
    public delegate int Calculator(int a, int b);

    public static int Addition(int a, int b)
    {
        return a + b;
    }

    public static int Subtraction(int a, int b)
    {
        return a - b;
    }

    public static int Multiplication(int a, int b)
    {
        return a * b;
    }

    public static int Division(int a, int b)
    {
        return a / b;
    }

    static void Main4()
    {
        Calculator c = Addition;
        c += Subtraction;
        c += Multiplication;
        c += Division;

        foreach (Calculator method in c.GetInvocationList())
        {
            int result = method(20, 10);
            Console.WriteLine("Result = " + result);
        }
    }
}