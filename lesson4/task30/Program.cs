int[] arrbool = new int[8];
for(int i = 0; i < arrbool.Length; i++)
{
    arrbool[i] = Random.Shared.Next(0, 2);
    Console.Write(arrbool[i]);
}