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
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age: ");
        byte age = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Your name is {0} and your age is {1} ", name, age);
        Console.WriteLine("What is your favorite day of week? ");
        byte favDayAnswer = Convert.ToByte(Console.ReadLine());
        string favDayAnswerStr = Enum.GetName(typeof(DaysOfWeek), favDayAnswer);
        Console.WriteLine("Your favorite day is {0}", favDayAnswerStr);
    }
}