using System;
using System.ComponentModel;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        for (int stl = 0; stl < array.GetUpperBound(1) + 1; stl++)
        {
            for (int str = 0; str < array.GetUpperBound(0) + 1; str++)
            {
                Console.Write(array[str, stl] + " ");            
            }
            Console.WriteLine();
        }
    }
}