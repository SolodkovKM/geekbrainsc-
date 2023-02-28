using ClassesLibrary;
const int LENGTH = 10;
int[] filled_int_array = new ArrayWork().FillArray(LENGTH, -10, 10);
double[] filled_double_array = new ArrayWork().FillArray(LENGTH, 10.2);
char[] filled_string_array = new ArrayWork().FillArray(LENGTH);

$"[{string.Join(',', filled_int_array)}]".Print();
$"[{string.Join(',', filled_double_array.Select(x=> Math.Round(x, 2)))}]".Print();
$"[{string.Join(',', filled_string_array)}]".Print();
"Введите число".PrintGet().Print();