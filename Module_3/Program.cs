using System;
using System.ComponentModel;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int a = 0;

        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)   //перебираем строки 
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++) //для каждой строки перебираем столбцы
            {
                for (int m = k+1; m < arr.GetUpperBound(1) + 1; m++)
                {
                    if (arr[i, k] > arr[i, m])
                    {
                        a = arr[i, k];
                        arr[i, k] = arr[i, m];
                        arr[i, m] = a;
                        
                    }
                    else { continue; }
                    

                }
                Console.Write(arr[i,k] + "  ");
            }
            Console.WriteLine();
        }     
        
    }
}