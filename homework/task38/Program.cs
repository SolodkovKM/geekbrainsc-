
double DifferenceOfValue(double[] array)
{
    double MaxValue = array[0];
    double MinValue = array[0];
    foreach(double i in array)
    {
        if(i > MaxValue) MaxValue = i;
        if(i < MinValue) MinValue = i;
    }
    return(MaxValue - MinValue);
}


double[] filled_array = new double[5]{1, 2.2, 1.5, -2.5, -10.8};
Console.WriteLine($"[{string.Join('|', filled_array)}] -> {DifferenceOfValue(filled_array)}");
