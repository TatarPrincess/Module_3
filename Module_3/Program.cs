using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;

class Programm
{
    static void Main(string[] args)
    {

    }

    class User
    {
        private int age;
        private string login;
        private string email;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Login
        {
            get 
            {
                return login;
            }
            set
            {
                if (value.Length >= 3)
                {
                    login = value;
                }
                else Console.WriteLine("Длина поля логин должна быть более 3 символов длиной");
                
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (value.Contains('@'))
                {
                    email = value;
                }
                else Console.WriteLine("Email должен содержать символ @");

            }

        }
    }
}





