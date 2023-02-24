using System.Linq;

int[] FillArray(int length, int leftnum, int rightnum)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

bool CheckNum(int[] array, int num)
{
    return array.Contains(num);
}

int[] filled_array = FillArray(10, -9, 10);
Console.WriteLine($"{string.Join(',', filled_array)} {CheckNum(filled_array, 3)}");