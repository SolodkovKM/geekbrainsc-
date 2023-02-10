void msg() {
    Console.WriteLine("Введите число");
    var num = Console.ReadLine();
    if(int.TryParse(num, out int isnum)) {   
       Console.WriteLine("Квадрат числа:" + isnum*isnum );
    }
    else {
        Console.WriteLine("это не число");
        msg();
    }
}
msg();