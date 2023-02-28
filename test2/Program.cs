using ClassesLibrary;

int[] filled_int_array = new ArrayWork().FillArray(10, -10, 10);
double[] filled_double_array = new ArrayWork().FillArray(10, 10.2);
char[] filled_string_array = new ArrayWork().FillArray(10);

Console.WriteLine($"[{string.Join(',', filled_int_array)}]");
Console.WriteLine($"[{string.Join(',', filled_double_array.Select(x=> Math.Round(x, 2)))}]");
Console.WriteLine($"[{string.Join(',', filled_string_array)}]");

