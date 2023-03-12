namespace IVT_Vyuka_Rekurze.Recursion;

public static class Factorial
{
    #region Calc

    private static int Fac(int n)
    {
        //Stopka
        if (n <= 1)
            return 1;

        //Rekurze
        return n * Fac(n - 1);
    }

    #endregion

    #region Print

    public static void PrintFactorial(int n)
    {
        Console.WriteLine(Fac(n));
    }

    #endregion
}