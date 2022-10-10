using System;
using System.ComponentModel;
using System.Drawing;

class MainClass
{
    static void Main(string[] args)
    {
        static double PowerUp(int N, byte pow)
        {
            if (pow == 0) { return 1; }
            if (pow > 0)
            {
                double res = Math.Pow(N, pow);
                Console.WriteLine("Число: {0}, степень: {1}, результат: {2}", N, pow, res);
                return PowerUp(N, --pow);
            }
            
            return 1;     
            
        }

        Console.WriteLine("Введите число: ");
        int digit = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень: ");
        byte pow1 = Byte.Parse(Console.ReadLine());
        PowerUp(digit, pow1);
        
    }

    //static void Main(string[] args)
    //{
    //    //static decimal Factorial(int x)
    //    //{
    //    //    if (x == 0)
    //    //    {
    //    //        return 1;
    //    //    }
    //    //    else
    //    //    {
    //    //        decimal res1 = x * Factorial(x - 1);
    //    //        Console.WriteLine("x равен: {0}, результат равен: {1}", x, res1);
    //    //        return res1;
    //    //    }
    //    //}
    //    //Console.WriteLine("Введите число");
    //    //int digit = Int32.Parse(Console.ReadLine());
    //    //decimal res = Factorial(digit);
    //    //Console.WriteLine("Результат: {0}", res);
    //    //Console.WriteLine("Макс децимал: {0}", Decimal.MaxValue);
    //    //Console.WriteLine("Макс лонг: {0}", Int64.MaxValue);
    //}


    //static void Main(string[] args)
    //{
    //Console.WriteLine("Напишите что-то");
    //var str = Console.ReadLine();

    //Console.WriteLine("Укажите глубину эха");
    //var deep = int.Parse(Console.ReadLine());

    //Echo(str, deep);

    //Console.ReadKey();
    //    class Test
    //{
    //    public static void Main()
    //    {
    //        string test = "before passing";
    //        Console.WriteLine("outside method before change inside method: " + test);
    //        TestI(test);
    //        Console.WriteLine("outside method after change inside method: " +  test);
    //    }

    //    public static void TestI(string test)
    //    {
    //        test = "after passing";
    //        Console.WriteLine("inside method: " + test);
    //    }
    //}
}

//static void Echo(string saidWord, int deep)
//{
//    var modif = saidWord;

//    if (modif.Length > 2)
//    {
//        modif = modif.Remove(0, 2);
//    }

//    var color = (ConsoleColor) deep; 
//    Console.ForegroundColor = color;
//    Console.WriteLine("..." + saidWord);



//    if (deep > 1)
//    {
//        Echo(modif, deep - 1);
//    }
//}
//}