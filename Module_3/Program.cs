using System;
using System.ComponentModel;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int summa = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            summa = summa + arr[i];          
        }

        Console.WriteLine("Сумма элементов массива: {0}", summa);
    }
}