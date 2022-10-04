using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = getArrayFromConsole();
        var b = 0;
        
        for (int x = 0; x < arr.Length; x++)
        {
            for (int y = x + 1; y < arr.Length; y++)
            {
                if (arr[x] > arr[y])
                {
                    b = arr[x];
                    arr[x] = arr[y];
                    arr[y] = b;
                }
                else continue;
            }
        }
        
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        };


    }
    static int[] getArrayFromConsole()
    {
        var result = new int[5];
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i+1);
            result[i] = Convert.ToInt32(Console.ReadLine());
        }
        return result;
    }

}