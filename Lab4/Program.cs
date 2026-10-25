using System;

public class Program
{
    // in. Արժեքը կարդում ենք, բայց այս մեթոդում չենք փոխում։
    public static void A(in int number, int multiplier = 2)
    {
        int result = number * multiplier;
        Console.WriteLine("A-ի արդյունքը՝ " + result);
    }

    // out. Մեթոդը պարտադիր արժեք է տալիս result փոփոխականին։
    public static void B(out int result)
    {
        result = 25;
    }

    // ref. Փոփոխվում է հենց Main-ում ստեղծված փոփոխականը։
    public static void C(ref int number, int step = 1)
    {
        number = number + step;
    }

    // params. Կարելի է փոխանցել ցանկացած քանակի int թվեր։
    public static int SumValues(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }

        return sum;
    }

    public static void Main()
    {
        int number = 10;

        Console.WriteLine("Սկզբում number = " + number);
        A(in number);
        A(in number, 3);
        Console.WriteLine("A-ից հետո number = " + number);

        int newNumber;
        B(out newNumber);
        Console.WriteLine("B-ից ստացված թիվը = " + newNumber);

        C(ref number);
        Console.WriteLine("C-ից հետո, լռելյայն step=1՝ " + number);

        C(ref number, 4);
        Console.WriteLine("C-ից հետո, step=4՝ " + number);

        int firstSum = SumValues(1, 2, 3, 4);
        int secondSum = SumValues(10, 20);

        Console.WriteLine("1 + 2 + 3 + 4 = " + firstSum);
        Console.WriteLine("10 + 20 = " + secondSum);
    }
}
