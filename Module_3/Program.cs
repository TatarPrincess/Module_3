using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    {
        var myAge = 20;
        Console.WriteLine("Before - {0}", myAge);
        changeAge(ref myAge);

        static void changeAge(ref int myAge)
        {
            myAge = 38;
            Console.WriteLine("In the method - {0}", myAge);
        }

        Console.WriteLine("After - {0}", myAge);
    }
}