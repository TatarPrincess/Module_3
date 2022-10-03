using System;
using System.ComponentModel;

class MainClass
{
    public static void Main(string[] args)
    {
           (
             string name,
             string surname,
             string login,
             int loginLength,
             bool hasPet,
             int age,
             string[] userColors
            ) User;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter your name: ");
            User.name = Console.ReadLine();

            Console.WriteLine("Enter your surname: ");
            User.surname = Console.ReadLine();

            Console.WriteLine("Enter your login: ");
            User.login = Console.ReadLine();

            Console.WriteLine("Длина вашего логина: {0}", User.login.Length);

            Console.WriteLine("У вас есть домашнее животное?");

            if (Console.ReadLine() == "Да")
            {
                User.hasPet = true;
            }
            else
            {
                User.hasPet = false;
            };

            Console.WriteLine("Введите ваш возраст: ");
            User.age = Convert.ToByte(Console.ReadLine());

            User.userColors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            User.userColors = Console.ReadLine().Split(' ');
            foreach (string item in User.userColors)
            {
                Console.WriteLine(item);
            }
        }
            




      
        Console.ReadKey();
           
    }
}