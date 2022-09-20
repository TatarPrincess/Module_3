using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string myName, hello, age;
        myName = "\t My name is Ksusha \n";
        hello = "\t Hello, world! \n";
        age = "\t I'm 38";

        Console.WriteLine(hello + myName + age);

        Console.ReadKey();
    }
}