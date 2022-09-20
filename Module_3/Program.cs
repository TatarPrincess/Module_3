using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string myName, myPet, myAge, myShoeSize;

        const byte age = 38;
        const bool havePet = true;
        const float shoeSize = 37.5f;
        const string name = "Ksusha";

        myName = $"\t My name is {name}\n";
        myAge = $"\t My age is {age} \n";
        myPet = $"\t Do I have a pet? {havePet}\n";
        myShoeSize = $"\t My shoe size is {shoeSize}";

        Console.WriteLine(myName + myAge + myPet + myShoeSize);

        Console.ReadKey();
    }
}