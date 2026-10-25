using System;

public class MatrixData
{
    private int n;
    private int a;
    private int b;
    private int[,] matrix;

    // get/set-ը կարճ գրելաձևով է, ինչպես պահանջվում է առաջադրանքում։
    public int N { get => n; private set => n = value; }
    public int A { get => a; private set => a = value; }
    public int B { get => b; private set => b = value; }

    public MatrixData(int size, int firstNumber, int lastNumber)
    {
        if (size <= 0 || firstNumber > lastNumber)
        {
            throw new ArgumentException("Սխալ չափ կամ միջակայք։");
        }

        N = size;
        A = firstNumber;
        B = lastNumber;

        matrix = new int[N, N];
        FillMatrix();
    }

    private void FillMatrix()
    {
        Random random = new Random();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = random.Next(A, B + 1);
            }
        }
    }

    public void ShowMatrix()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    public int CountOddNumbers()
    {
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matrix[i, j] % 2 != 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
}

public class Program
{
    public static void Main()
    {
        int n = 4;
        int a = 1;
        int b = 10;

        MatrixData myMatrix = new MatrixData(n, a, b);

        Console.WriteLine("Մատրիցայի չափը՝ " + myMatrix.N + " x " + myMatrix.N);
        Console.WriteLine("Թվերի միջակայքը՝ [" + myMatrix.A + ", " + myMatrix.B + "]");
        Console.WriteLine("Մատրիցան՝");
        myMatrix.ShowMatrix();

        int oddCount = myMatrix.CountOddNumbers();
        Console.WriteLine("Կենտ թվերի քանակը՝ " + oddCount);
    }
}
