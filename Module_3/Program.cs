using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class Programm
{
    static void Main(string[] args)
    {
        var arr = new int[] { 1, 2, 3, 4 };
        IndexingClass myClass = new IndexingClass(arr);
        Console.WriteLine("Третий элемент: {0}", myClass[3]);
        Console.WriteLine("Пятый элемент: {0}", myClass[5]);
        myClass[0] = 190;
        Console.WriteLine("Первый элемент: {0}", myClass[0]);
    }    

}

class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    public int this [int index]
    {
        set {
            if (index >= 0 && index < array.Length)
            {
                array[index] = value;
            }
        }
        get {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else return -1;
        }
    }
}




