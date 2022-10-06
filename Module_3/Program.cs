using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {
        int size = 3;
        var arr = getArrayFromConsole(ref size);
        Console.WriteLine();
        sortArray(out int[] sorteddesc, out int[] sortedasc, arr);

        foreach (int item in sorteddesc)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        foreach (int item in sortedasc)
        {
            Console.Write(item + " ");
        }
    }
    static int[] getArrayFromConsole(ref int size)
    {
        size += 3;
        var result = new int[size];
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i+1);
            result[i] = Convert.ToInt32(Console.ReadLine());
        }
        return result;
    }
    static void sortArray(out int[] sorteddesc, out int[] sortedasc, in int[] array)
    {
        sorteddesc = sortArrayDesc(array);
        sortedasc = sortArrayAsc(array);
              
    }
    static int[] sortArrayAsc(in int[] array)
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

        int[] arraySortedAsc = new int[6];

        for (int i = 0; i < array.Length; i++)
        {
            arraySortedAsc[i] = array[i];        
        }

        return arraySortedAsc;
    }

    static int[] sortArrayDesc(in int[] array)
    {
        var b = 0;

        for (int x = 0; x < array.Length; x++)
        {
            for (int y = x + 1; y < array.Length; y++)
            {
                if (array[x] < array[y])
                {
                    b = array[x];
                    array[x] = array[y];
                    array[y] = b;
                }
                else continue;
            }
        }

        int[] arraySortedDesc = new int[6];

        for (int i = 0; i < array.Length; i++)
        {
            arraySortedDesc[i] = array[i];
        }

        return arraySortedDesc;

    }
}