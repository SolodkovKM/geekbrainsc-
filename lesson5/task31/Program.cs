int[] FillArray(int length, int leftnum, int rightnum )
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

(int, int) Sum(int[] array)
{
    int upsum = 0;
    int lowsum = 0;
    foreach(int i in array)
    {
        if (i > 0) upsum += i;
        if (i < 0) lowsum += i;
    }
    return (upsum, lowsum);
}
int[] filled_array = FillArray(12, -9, 10);
Console.WriteLine($"[{string.Join(',',filled_array)}] {Sum(filled_array).Item1}, {Sum(filled_array).Item2}");