using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    static void ShowColor(string name)
    {
        Console.WriteLine("{0}, \n напишите свой любимый цвет на английском с маленькой буквы", name);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, your color is red!", name);
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, your color is green!", name);
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("{0}, your color is cyan!", name);
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("{0}, your color is yellow!", name);
                break;
        }
    }

    public static void Main(string[] args)
    {

        var (name, age) = ("Евгения", 27);

        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", name);
        Console.WriteLine("Ваш возраст: {0}", age);

        ShowColor(name);


    }

}