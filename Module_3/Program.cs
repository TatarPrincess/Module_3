using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class Programm
{
    static void Main(string[] args)
    {
    }

    abstract class ComputerPart
    {
        private string name;
        public ComputerPart(string name)
        {
            this.name = name;
        }

        abstract public void Work();
    }

    class Processor : ComputerPart 
    {
        public Processor() : base("Процессор 1")
        { 
         
        }
        public override void Work()
        {
            Console.WriteLine("Работа процессора");
        }

    }
    class MotherBoard : ComputerPart
    {
        public MotherBoard() : base("MotherBoard 1")
        {

        }
        public override void Work()
        {
            Console.WriteLine("Работа MotherBoard");
        }

    }
    class GraphicCard : ComputerPart
    {
        public GraphicCard() : base("GraphicCard 1")
        {

        }
        public override void Work()
        {
            Console.WriteLine("Работа GraphicCard");
        }

    }
}

