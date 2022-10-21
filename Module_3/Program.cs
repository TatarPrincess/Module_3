using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class A
{
    public virtual void Display()
    {
        Console.WriteLine("A");
    }
}
class B : A
{
    public new void Display()
    {
        Console.WriteLine("B");
    }
}
class C : A
{
    public override void Display()
    {
        Console.WriteLine("C");
    }
}

class D : B
{
    public new void Display()
    {
        Console.WriteLine("D");
    }
}

class E : C
{
    public new void Display()
    {
        Console.WriteLine("E");
    }
}

class Program
{
    static void Main(string[] args)
    {
        D d = new D();
        E e = new E();

        d.Display();      //D
        ((A)e).Display(); //C
        ((B)d).Display(); //B
        ((A)d).Display(); //A

    }
}


