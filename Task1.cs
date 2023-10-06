using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        GetInput(out string value1, out string value2);
        Try2ParseValues(value1, value2, out int num1, out int num2, out bool isInteger);
        CheckValues(isInteger, num1, num2);
    }

    static void GetInput(out string value1, out string value2)
    {
        Console.WriteLine("Enter the first value:");
        value1 = Console.ReadLine();

        Console.WriteLine("Enter the second value:");
        value2 = Console.ReadLine();
    }

    static void Try2ParseValues(string value1, string value2, out int num1, out int num2, out bool isInteger)
    {
        bool isValue1Integer = int.TryParse(value1, out num1);
        bool isValue2Integer = int.TryParse(value2, out num2);

        isInteger = isValue1Integer && isValue2Integer;
    }
    
    static void CheckValues(bool isInteger, int num1, int num2){
        if (isInteger)
        {
            Console.WriteLine($"Sum: {num1+num2}");
        }
        else
        {
            Console.WriteLine("At least one of the values is not an integer.");
        }
    }
}
