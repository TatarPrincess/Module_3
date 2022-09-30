using System;
using System.ComponentModel;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, -5, 8, 9, -6, -1, 77};
        int quant = 0;

        foreach (var num in array)
        {
            if (num > 0)
            {
                quant++;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine(quant);
        

    }
}