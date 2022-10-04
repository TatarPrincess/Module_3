using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = getArrayFromConsole();
        var sortedArr = sortArray(arr);
        
        
        foreach (var item in sortedArr)
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
    static int[] sortArray(string name, params int[] array)
    {
        var b = 0;
        Console.WriteLine(name);

        for (int x = 0; x < array.Length; x++)
        {
            for (int y = x + 1; y < array.Length; y++)
            {
                if (array[x] > array[y])
                {
                    b = array[x];
                    array[x] = array[y];
                    array[y] = b;
                }
                else continue;
            }
        }
        return array;
    }

}