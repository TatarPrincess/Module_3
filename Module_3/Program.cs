using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;

class Programm
{
    
    static void Main(string[] args)
    {
        Console.WriteLine(IntExtension.GetNegative(-5));
        Console.WriteLine(IntExtension.GetNegative(8));
        Console.WriteLine(IntExtension.GetPositive(3));
        Console.WriteLine(IntExtension.GetPositive(-6));

    }

    public class IntExtension
    {
        public static int GetNegative(int a)
        {
            int A = a;
            A = (a <= 0) ? a : -a;

            return A;
           
        }

        public static int GetPositive(int a)
        {
            int A = a;
            A = (a >= 0) ? a : -a;

            return A;

        }
    }

}

