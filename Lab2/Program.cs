using System;

public class Program
{
    // int թվի համար x-ը գումարում ենք n անգամ։
    public static int ToMultiplicate(int x, int n = 2)
    {
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum = sum + x;
        }

        return sum;
    }

    // double թվի համար կատարվում է նույն գործողությունը։
    public static double ToMultiplicate(double x, int n = 2)
    {
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum = sum + x;
        }

        return sum;
    }

    // string-ի դեպքում + նշանը միացնում է տողերը։
    public static string ToMultiplicate(string x, int n = 2)
    {
        string result = "";

        for (int i = 0; i < n; i++)
        {
            result = result + x;
        }

        return result;
    }

    public static void Main()
    {
        int wholeNumber = 5;
        double decimalNumber = 1.5;
        string word = "Hi";

        int intDefault = ToMultiplicate(wholeNumber);
        int intWithN = ToMultiplicate(wholeNumber, 3);

        double doubleDefault = ToMultiplicate(decimalNumber);
        double doubleWithN = ToMultiplicate(decimalNumber, 3);

        string stringDefault = ToMultiplicate(word);
        string stringWithN = ToMultiplicate(word, 3);

        Console.WriteLine("int, լռելյայն n=2՝ " + intDefault);
        Console.WriteLine("int, n=3՝ " + intWithN);
        Console.WriteLine("double, լռելյայն n=2՝ " + doubleDefault);
        Console.WriteLine("double, n=3՝ " + doubleWithN);
        Console.WriteLine("string, լռելյայն n=2՝ " + stringDefault);
        Console.WriteLine("string, n=3՝ " + stringWithN);
    }
}
