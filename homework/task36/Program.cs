int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

int SumNegativeIndex(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1) sum += array[i];
    }
    return sum;
}
int[] filled_array = FillArray(10, -10, 10);

Console.WriteLine($"{string.Join(',', filled_array)} -> {SumNegativeIndex(filled_array)}");