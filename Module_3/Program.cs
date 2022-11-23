using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace DelegatePractices
{
    class Program
    {
        public delegate Car carHandler();
        static void Main(string[] args)
        {
            Lexus lexus = new Lexus("12345");
            carHandler carHandler = lexus.getCarInfo;
            Console.WriteLine(carHandler.Invoke().smth);

        }
    }

    class Car 
    {
        public string smth;
        public Car(string smth)
        { 
          this.smth = smth;
        }
    }
    class Lexus : Car 
    {
        
        public Lexus(string smth) : base(smth)
        {
            
        }

        public Lexus getCarInfo()
        {
           return this;
        }
    }

    
}






