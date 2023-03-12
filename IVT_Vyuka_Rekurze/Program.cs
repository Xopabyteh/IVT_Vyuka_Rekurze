using IVT_Vyuka_Rekurze;
using IVT_Vyuka_Rekurze.Recursion;
using IVT_Vyuka_Rekurze.Sorting;

#region Recursion

//Fib:
//Fibonacci.PrintFibonacciNumbers(10);

//Fac:
//Factorial.PrintFactorial(30);

//Grains:
Console.WriteLine(Rice.SquaresNeeded(0));
Console.WriteLine(Rice.SquaresNeeded(1));
Console.WriteLine(Rice.SquaresNeeded(2));
Console.WriteLine(Rice.SquaresNeeded(3));
Console.WriteLine(Rice.SquaresNeeded(4));

//Database example:
//var database = new Database();
//database.SeedDatabase();
//database.PrintDatabase();

#endregion

#region Sorting
//https://visualgo.net/en/sorting

void PrintArr(int[] arr)
{
    foreach (var i in arr)
    {
        Console.Write($"{i}  ");
    }
}

var arr = new int[] {42, 37, 37, 26, 23, 17, 17, 10, 11, 9, 13};

PrintArr(arr);

//Sorting.BubbleSort(arr);
Sorting.InsertionSort(ref arr);


Console.WriteLine("=>");
PrintArr(arr);


#endregion