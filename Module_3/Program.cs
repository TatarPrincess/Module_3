using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class Programm
{
    static void Main(string[] args)
    {
        //var department = GetCurrentDepartment();
        Console.WriteLine("введите количество пассажиров");
        int result;
        int.TryParse(Console.ReadLine(), out result);
        int? quant = result;
        if (result <= 0) quant = null;
        Bus bus = new Bus(quant);

        bus.PrintStatus();
    }

    static Department GetCurrentDepartment()
    {
        Console.WriteLine("Введите название города");
        City city = new City(Console.ReadLine());
        Console.WriteLine("Введите тип компании");
        string compType = Console.ReadLine();
        Console.WriteLine("Введите имя компании");
        string compName = Console.ReadLine();
        Company company = new Company(compType, compName);

        if (company.Type == "Банк" && city.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", company.Name);
        }
        else Console.WriteLine("ничего");

        return new Department(company, city);
    }

}
class Bus
{
    public int? Load;
    public Bus(int? load)
    {
        Load = load;
    }

    public void PrintStatus()
    {
        if (Load != null)
        {
            Console.WriteLine("Количество пассажиров - {0}", Load);
        }
        else Console.WriteLine("Автобус пуст");

    }
}
class Company
{
    public string Type;
    public string Name;
    public Company(string type, string name = "Неизвестная компания")
    {
        Type = type;
        Name = name;
    }
}

class City
{
    public string Name;
    public City(string name)
    {
        Name = name;    
    }
}

class Department
{
    public Company Company;
    public City City;

    public Department(Company compData, City cityData)
    {
        Company = compData;
        City = cityData;
    }

    

}

