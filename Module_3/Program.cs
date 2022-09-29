using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите свое имя");
        string name = Console.ReadLine();
        
        char [] letters =  new char [100];
        int number = 0;

        for (int i = 0; i < name.Length; i++)
        {
            letters[i] = name[i];
            number++;            
        }
        
        string name_l = "";
                

        for (int i = number; i > 0; i--)
        {
            name_l = name_l + " " + letters[i-1];
        }
        
        Console.WriteLine($"Ваше имя по буквам в обратном порядке:  {name_l}");
        Console.WriteLine($"Первая буква вашего имени: {letters[0]}");
    }
}