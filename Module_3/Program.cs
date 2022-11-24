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
    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater<in T>
    {
        public void Update(T entity);
    }

    public class UserService : IUpdater <User>
    {

        public void Update(User user)
        {
            Console.WriteLine(user);
        }
    }

    class Program 
    {
        public static void Main(string[] args)
        {

            IUpdater<User> user = new UserService();
            IUpdater<Account> account = new UserService();
            
            user.Update(new User());
            account.Update(new Account());
        }
    }

    
}






