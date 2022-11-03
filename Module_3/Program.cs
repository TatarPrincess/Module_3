using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;


static class CashPaymentExtensions
{
    public static void PaymentByInstalments(this CashPayment cashPayment)
    {
        Console.WriteLine("Выбрана оплата в рассрочку");

    }
}

class Programme
{
    static void Main(string[] args)
    {
        ProductList pList = new ProductList();
        string[] authors = { "Артур Конан Дойль", "Агата Кристи", "Джеймс Хедли Чейз" };
        Product productBought = pList[authors[new Random().Next(0, 2)], new Random().Next(0, 3)];
        Order order = new Order(productBought);
        Console.WriteLine("Ваш заказ: \n #{0} от {1} \n на покупку книги \"{2}\" в количестве {3} по цене {4} рублей",
            order.number, order.date, productBought.Name, productBought.Quantity, productBought.Price);
    }
}
    

class Order 
{
    public int number;
    public DateOnly date;
    public Product productsBought;


    public Order(Product productsBought)
    {
        //order's own attributes
        this.number = new Random().Next();
        this.date = DateOnly.FromDateTime(DateTime.Today);

        //products bought
        this.productsBought = productsBought;

        //payment
        Console.WriteLine("Выберите тип оплаты: введите 1, в случае оплаты картой, " +
            "в случае оплаты наличными, введите 2, в случае оплаты наличными в рассрочку, введите 3");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                CardPayment cardPayment = new CardPayment("1234456767898765", "Ivanov Gena", "12/2022", 345, this.productsBought.Price);
            }
            else if (answer == "2")
            {
                int receipt = new CashPayment().getReceiptNumber();

            }
            else if (answer == "3")
            {
              CashPayment cashPayment = new CashPayment();
              cashPayment.PaymentByInstalments();
            }
            else Console.WriteLine("Введен не верный тип оплаты");

        //delivery
        Console.WriteLine("Выберите тип доставки: введите 1, в случае доставки на дом, 2 - в случае доставки в пункт выдачи, 3 - в случае доставки в магазин нашей сети");

        switch (Console.ReadLine())
        {
            case "1":
                {
                    Console.WriteLine("Введите адрес доставки");
                    string address = Console.ReadLine();
                    Courier courier = new CourierList()[new Random().Next(0, 5)];
                    var minTimeOfDelivery = TimeOnly.FromDateTime(DateTime.Now);
                    new HomeDelivery<Courier>(address, courier, minTimeOfDelivery);
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Введите город доставки");
                    string city = Console.ReadLine();
                    if (city != "Москва" & city != "Долгопрудный" & city != "Химки")
                        Console.WriteLine("Введен не верный город доставки");
                   
                    PickPoint pickPoint = new PickPointList()[city, new Random().Next(0, 1)];
                    Courier courier = new CourierList()[new Random().Next(0, 5)];
                    DateOnly dateOfDelivery = DateOnly.FromDateTime(DateTime.Today).AddDays(3);
                    new PickPointDelivery(pickPoint, courier, dateOfDelivery, dateOfDelivery.AddDays(5));
                    break;    
                }
            case "3":
                {
                    Console.WriteLine("Введите город доставки");
                    string city = Console.ReadLine();
                    if (city != "Москва" & city != "Долгопрудный" & city != "Химки")
                        Console.WriteLine("Введен не верный город доставки");

                    PickPoint pickPoint = new PickPointList()[city, new Random().Next(0, 1)];
                    DateOnly dateOfDelivery = DateOnly.FromDateTime(DateTime.Today).AddDays(1);
                    new ShopDelivery(pickPoint, dateOfDelivery, dateOfDelivery.AddDays(30));
                    break;
                }
            default: 
                Console.WriteLine("Введен не верный тип доставки"); break;
        }
    }

    
}


abstract class Delivery<T>
{
    public T pickpoint;
    public DateOnly dateOfDelivery;

    public Delivery(T pickpoint, DateOnly dateOfDelivery)
    {
        this.pickpoint = pickpoint;
        this.dateOfDelivery = dateOfDelivery;
    }
}

class HomeDelivery <T>: Delivery<string>
{
    private TimeOnly minTimeOfDelivery;
    private TimeOnly maxTimeOfDelivery;
    private readonly int timeRange = 3;
    private T courier;
    public HomeDelivery(string pickpoint, T courier, TimeOnly minTimeOfDelivery)
        : base(pickpoint, DateOnly.FromDateTime(DateTime.Today).AddDays(2))
    {
        this.courier = courier;
        this.minTimeOfDelivery = minTimeOfDelivery;
        this.maxTimeOfDelivery = this.minTimeOfDelivery.AddHours(timeRange);
    }
}
public class Courier
{
    public string name = "";
    public string phoneNumber = "";
    public string transportСompany = "";      
}

public class CourierList
{
    private Courier[] сourierList;
    public CourierList()
    {
        сourierList = new Courier[]
        {
            new Courier
            {
                name = "Иванов Иван",
                phoneNumber = "+7-926-456-76-43",
                transportСompany = "Yandex"
            },
            new Courier
            {
                name = "Махалов Петр",
                phoneNumber = "+7-926-111-34-43",
                transportСompany = "Yandex"
            },
            new Courier
            {
                name = "Смирнов Валерий",
                phoneNumber = "+7-926-466-76-66",
                transportСompany = "DostaVista"
            },
            new Courier
            {
                name = "Манин Антон",
                phoneNumber = "+7-926-156-34-77",
                transportСompany = "DostaVista"
            },
            new Courier
            {
                name = "Суриков Тим",
                phoneNumber = "+7-926-426-26-23",
                transportСompany = "Ozon"
            },
            new Courier
            {
                name = "Михалков Никита",
                phoneNumber = "+7-926-333-33-33",
                transportСompany = "Ozon"
            }       
        };
    }

    public Courier this[int idx]
    {
        get => сourierList[idx];
    }
}

class PickPointDelivery: Delivery<PickPoint> 
{
    private DateOnly lastDayOfKeeping;
    private Courier courier;
    public PickPointDelivery(PickPoint pickpoint, Courier courier, DateOnly dateOfDelivery, DateOnly lastDayOfKeeping) 
        : base (pickpoint, dateOfDelivery)
    {
        this.lastDayOfKeeping = lastDayOfKeeping;
        this.courier = courier;
    }

}

public class PickPoint
{
  public string name;
  public string address;
  public string additionalDescription;
  public string workingHours;

  public PickPoint(string name, string address, string additionalDescription, string workingHours)
  {
     this.name = name;
     this.address = address;
     this.additionalDescription = additionalDescription;
     this.workingHours = workingHours;
  }
}

public class PickPointList
{
    private Dictionary<string, List<PickPoint>> pickPointList;
    public PickPointList()
    {
        pickPointList = new()
        {
        ["Долгопрудный"] = new()
        {
          new PickPoint("1", "г. Долгопрудный, Новый бульвар, 1", "2 подъезд, рядом с магазином \"Цветы\"", "10.00 - 19.00"),
          new PickPoint("2", "г. Долгопрудный, ул.Ракетостроителей, 9к3", "в магазине \"Дары Армении\"", "8.00 - 20.00")
        },
        ["Химки"] = new()
        {
          new PickPoint("1", "г. Химки, ул. Советская, 35", "вход со двора", "09.00 - 18.00"),
          new PickPoint("2", "г. Химки, ул. Красноармейская, 27", "рядом с пунктом выдачи \"Озон\"", "8.00 - 20.00")
        },
        ["Москва"] = new()
        {
          new PickPoint("1", "г. Москва, ул. Шарикоподшипниковская, 10", "вход со стороны фонтана", "09.00 - 18.00"),
          new PickPoint("2", "г. Химки, ул. Петрозаводская, 40", "рядом с пунктом выдачи \"Озон\"", "8.00 - 20.00")
        }
        };     
    }

    public PickPoint this[string city, int pointIdx]
    {
        get => pickPointList[city][pointIdx];        
    }
}

class ShopDelivery : Delivery<PickPoint>
{
    private DateOnly lastDayOfKeeping;
    
    public ShopDelivery(PickPoint pickpoint, DateOnly dateOfDelivery, DateOnly lastDayOfKeeping)
        : base(pickpoint, dateOfDelivery)
    {
        this.lastDayOfKeeping = lastDayOfKeeping;       
    }
};


public abstract class Payment 
{
    protected decimal amount;
    protected static int currency = 810;


    public Payment(decimal amount)
    {
        this.amount = amount;        
    }

    public Payment ()
    {
        this.amount = 0;       
    }

    protected abstract void Pay();
   

}

public class CardPayment : Payment 
{
    private string cardNumber;
    private string cardHolderName;
    private string cardExpireDate;
    private int cvvCode;

    public CardPayment(string cardNumber, string cardHolderName, string cardExpireDate, int cvvCode, decimal amount) : base(amount)
    {
        this.cardNumber = cardNumber;
        this.cardHolderName = cardHolderName;
        this.cardExpireDate = cardExpireDate;
        this.cvvCode = cvvCode;
    }

    protected override void Pay()
    { 
      //интеграция с платежным шлюзом - выполнение операции оплаты по переданной карте на переданную сумму
    }
}

public class CashPayment : Payment
{
    private int receiptNumber;
    
    public CashPayment()
    {
        this.receiptNumber = new Random().Next(1, 10000);
    }
    protected override void Pay()
    {
        //интеграция с онлайн-кассой 
        
    }
    public int getReceiptNumber()
    {
        return this.receiptNumber;
    }
}




    public class Product
{
    private int id;
    private string name;
    private decimal price;
    private int quantity;

    public string Name
    { 
        get { return name; }
        set
        {
           if (String.IsNullOrEmpty(value)) Console.WriteLine("Наименование продукта должно быть задано");
           else name = value;
        }
    }
    public decimal Price 
    {
        get { return price; }
        set
        {
            if (value <= 0) Console.WriteLine("Цена продукта должна быть больше нуля");
            else price = value;
        }
    }

    public int Quantity
    {
        get { return quantity; }
        set
        {
            if (value <= 0) Console.WriteLine("Количество продукта должно быть больше нуля");
            else quantity = value;
        }
    }


    public Product (string name, decimal price, int quantity)
    {
        this.id = new Random().Next();
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}

public class ProductList
{
    private Dictionary<string, List<Product>> productlist;
    public ProductList()
    {
        productlist = new()
        {
            ["Артур Конан Дойль"] = new()

            {
              new Product("Этюд в багровых тонах", 2000, new Random().Next(1,2)),
              new Product("Знак четырёх", 1500, new Random().Next(1,3)),
              new Product("Долина ужаса", 800, new Random().Next(1,2)),
              new Product("Собака Баскервилей", 2100, new Random().Next(1,3)),

            },
            ["Агата Кристи"] = new()

            {
              new Product("Таинственное происшествие в Стайлз", 2000, new Random().Next(1,2)),
              new Product("Вечерний клуб \"Вторник\"", 1500, new Random().Next(1,3)),
              new Product("Человек в коричневом костюме", 800, new Random().Next(1,2)),
              new Product("Сверкающий цианид", 2100, new Random().Next(1,3)),

            },
            ["Джеймс Хедли Чейз"] = new()

            {
              new Product("Никаких орхидей для мисс Блендиш", 2000, new Random().Next(1,2)),
              new Product("Мёртвые не кусаются", 1500, new Random().Next(1,3)),
              new Product("Теперь это ему ни к чему", 800, new Random().Next(1,2)),
              new Product("12 китайцев и Мышка", 2100, new Random().Next(1,3)),

            }
        };

    }

    public Product this[string author, int index]
    {
        get => productlist[author][index];
    }
 }
     
