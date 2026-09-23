using System;

class Q5
{
    public delegate void Temperature(double celsius);

    public static void Fahrenheit(double celsius)
    {
        double f = (celsius * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit = " + f);
    }

    public static void Kelvin(double celsius)
    {
        double k = celsius + 273.15;
        Console.WriteLine("Kelvin = " + k);
    }

    static void Main()
    {
        Temperature t = Fahrenheit;
        t += Kelvin;

        t(25);
    }
}