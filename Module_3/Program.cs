using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = getArrayFromConsole(3);
        showArray(arr); 
    }
    static int[] getArrayFromConsole(int num = 5)
    {
        var result = new int[num];
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i+1);
            result[i] = Convert.ToInt32(Console.ReadLine());
        }
        return result;
    }
    static int[] sortArray(int[] array)
    {
        var b = 0;

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
    static void showArray(int[] arr, bool attr = false) 
    {
        int [] arrayToShow = arr;
        
        if (attr == true)
        {
            sortArray(arrayToShow);
        }

        foreach (var item in arrayToShow)
        {
            Console.WriteLine(item);
        };

    }

}