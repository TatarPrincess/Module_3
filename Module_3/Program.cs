using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Echo(str, deep);

        Console.ReadKey();
    }

    static void Echo(string saidWord, int deep)
    {
        var modif = saidWord;

        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }

        var color = (ConsoleColor) deep; 
        Console.ForegroundColor = color;
        Console.WriteLine("..." + saidWord);
        


        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }
}