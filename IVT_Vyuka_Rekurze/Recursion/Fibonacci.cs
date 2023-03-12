namespace IVT_Vyuka_Rekurze.Recursion;

public static class Fibonacci
{

    #region Fib

    private static int Fib(int i)
    {
        //Stopka
        if (i == 1)
            return 1;
        if (i == 2)
            return 1;

        //Rekurze
        return Fib(i - 1) + Fib(i - 2);
    }

    #endregion

    #region Print

    public static void PrintFibonacciNumbers(int amm)
    {
        for (int i = 1; i < amm; i++)
        {
            Console.WriteLine(Fib(i));
        }
    }

    #endregion

}