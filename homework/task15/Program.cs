Console.WriteLine("Введите номер дня недели");
int nDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(nDay == 6 || nDay == 7 ?  "да, выходной" :  "нет, не выходной");