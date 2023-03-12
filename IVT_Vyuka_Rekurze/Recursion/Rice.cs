namespace IVT_Vyuka_Rekurze.Recursion;

public static class Rice
{
    public static int SquaresNeeded(ulong grains)
    {
        if (grains <= 0)
            return 0;

        return SquaresNeeded(grains, 1, 1, 1);
    }

    private static int SquaresNeeded(ulong grains, ulong squaresTry, ulong squaresTotalFit, int depth)
    {
        if (grains <= squaresTotalFit)
            return depth;
        squaresTry *= 2;
        return SquaresNeeded(grains, squaresTry, squaresTotalFit + squaresTry, depth + 1);
    }
}