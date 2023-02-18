Console.WriteLine("Введите 3 координаты первой точки через пробел");
string[] Acord = Console.ReadLine().Split(" ");
Console.WriteLine("Введите 3 координаты второй точки через пробел");
string[] Bcord = Console.ReadLine().Split(" ");

double findpath(string[] Acord, string[] Bcord)
{
    double Ax = Convert.ToDouble(Acord[0]);
    double Ay = Convert.ToDouble(Acord[1]);
    double Az = Convert.ToDouble(Acord[2]);
    double Bx = Convert.ToDouble(Bcord[0]);
    double By = Convert.ToDouble(Bcord[1]);
    double Bz = Convert.ToDouble(Bcord[2]);
    return Math.Sqrt(Math.Pow(Ax-Bx, 2)+Math.Pow(Ay-By, 2)+Math.Pow(Az-Bz, 2));
}
Console.WriteLine(findpath(Acord, Bcord));

