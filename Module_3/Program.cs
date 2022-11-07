using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;



class Programme
{
    static void Main(string[] args)
    {
        string filePath = @"C:\Store\C#\SF\Module_3\Module_3\Program.cs";
        FileInfo fi = new FileInfo(filePath);

        StreamWriter sw = fi.AppendText();
        sw.WriteLine("время запуска - {0}", DateTime.Now);       
            

        StreamReader sr = fi.OpenText();
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
        
    }
}
    



