namespace IVT_Vyuka_Rekurze.Sorting;

public static class Sorting
{
    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }

    public static void InsertionSort(ref int[] arr)
    {
        var sortedList = new List<int>(arr.Length);

        sortedList.Add(arr[0]);

        for (int i = 1; i < arr.Length; i++)
        {
            for (int s = 0;; s++)
            {
                if (arr[i] <= sortedList[s] || s == sortedList.Count - 1)
                {
                    sortedList.Insert(s, arr[i]);
                    break;
                }
            }    
        }

        arr = sortedList.ToArray();
    }
}