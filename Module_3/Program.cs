using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Linq;

[Serializable]
class Contact
{
    public string Name { get; set; }
    public long PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string name, long phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}

class Programme
{
    static void Main(string[] args)
    {
        Contact contact = new Contact("Ivan", 89263453245, "ivan@gmail.com");
        Console.WriteLine("Object is created");

        BinaryFormatter formatter = new BinaryFormatter();
        string path = @"C:\Store\serObj.dat";
        using (var stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
        {
            formatter.Serialize(stream, contact);
            Console.WriteLine("Object is serialized");
        }

        using (var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
        {
            var newContact = (Contact)formatter.Deserialize(stream);
            Console.WriteLine("Object is deserialized");
        }
    }

    
}


