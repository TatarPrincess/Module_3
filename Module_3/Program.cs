using System;
using System.ComponentModel;

class MainClass
{
    public static void Main(string[] args)
    {
           (
             int age,
             bool havePet,
             string name,
             float shoeSize
            ) personalInfo;


            Console.WriteLine("Enter your name: ");
            personalInfo.name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            personalInfo.age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Do you have a pet?: ");

            if (Console.ReadLine() == "yes" 
            | Console.ReadLine() == "да"
            | Console.ReadLine() == "no" 
            | Console.ReadLine() == "нет")
            {
              personalInfo.havePet = true;             
            }
            else
            {
              personalInfo.havePet = false;
            };

            Console.WriteLine("What is your shoe size?: ");
            personalInfo.shoeSize = float.Parse(Console.ReadLine());

            Console.WriteLine("Your name is {0} and your age is {1} ", personalInfo.name, personalInfo.age);
            Console.WriteLine("Your shoe size is {0}", personalInfo.shoeSize);
            if (personalInfo.havePet == true)
            {
             Console.WriteLine("You have a pet");
            }
            else
            { 
             Console.WriteLine("You don't have a pet"); 
            };
            Console.ReadKey();
           
    }
}