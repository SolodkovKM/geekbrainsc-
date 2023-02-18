Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string ispalindrom(int num)
{
    int firstnum = num / 10000;
    int lastnum = num % 10;
    int secfirstnum = num / 1000 - firstnum * 10;
    int seclastnum = num % 100 / 10;
    if(firstnum == lastnum && secfirstnum == seclastnum) return "Это палиндром";
    else return "Это не палиндром";
}
Console.WriteLine(ispalindrom(number));
