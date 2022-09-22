using System;

class MainClass
{
    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    };


    public static void Main(string[] args)
    {
        //name
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        //age
        Console.WriteLine("Enter your age: ");
        byte age = Convert.ToByte(Console.ReadLine());
        //favorite day
        Console.WriteLine("What is your favorite day of week? ");
        byte favDayAnswer = Convert.ToByte(Console.ReadLine());
        string favDayAnswerStr = Enum.GetName(typeof(DaysOfWeek), favDayAnswer);
        //birthday
        Console.WriteLine("Enter your date of birth: ");
        string dateOfBirth = Console.ReadLine();

        Console.WriteLine("\tYour name is {0}\n \tYour age is {1}\n \tYour birthday is {2}\n \tYour favorite day is {3}\n", name, age, dateOfBirth, favDayAnswerStr);

    }
}