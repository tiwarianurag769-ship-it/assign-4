using System;

class Q2
{
    public delegate void StudentResult(string name, int marks);

    public static void DisplayDetails(string name, int marks)
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Marks: " + marks);
    }

    public static void CheckResult(string name, int marks)
    {
        if (marks >= 40)
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");
    }

    static void Main2()
    {
        StudentResult d = DisplayDetails;
        d("Mukul", 75);

        d = CheckResult;
        d("Mukul", 75);
    }
}