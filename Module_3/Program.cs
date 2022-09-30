using System;
using System.ComponentModel;

class MainClass
{
    public static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int a;
        
        Console.Write("Массив before:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
            
        }
        Console.WriteLine();

        for (int i = 0;  i < arr.Length; i++) //5, 6, 9, 1, 2, 3, 4    
        {
            for (int k = i+1; k < arr.Length; k++)
            {
                if (arr[i] > arr[k])
                {
                    a = arr[i];
                    arr[i] = arr[k];
                    arr[k] = a;

                    Console.Write("Массив на итерации k= {0}: ", k);
                    foreach (var item in arr)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    continue;
                }

                Console.Write("Массив на итерации i={0}: ", i);
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
            
            }

        }

        Console.Write("Массив after:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");

        }
    }
}