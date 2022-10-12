using System;
using System.ComponentModel;
using System.Drawing;

class Programm
{
    public static void Main(string[] args)
    {
        (string name,
         string surname,
         int age,
         bool hasPet,
         int petQuant,
         string[] petNames,
         string[] favColors) anketa;

        string [] getPetNameArray (int quant)
        {            
           Console.WriteLine("Перечислите имена питомцев через запятую ");
           string answer = Console.ReadLine();
           string [] arr = new string[quant];
           return answer.Split(',');             
            
        }

        string[] getfavColors(int quant)
        {
            if (quant > 0)
            {
                Console.WriteLine("Перечислите любимые цвета через запятую ");
                string answerColor = Console.ReadLine();
                anketa.favColors = new string[quant];
                return answerColor.Split(','); ;
            }
            else
            {
                var emptyArr = new string[] {""};
                return emptyArr;
            }
           
        }

        bool isCorrectInput(string input, string type)
        {
            int tmp;
            if (!int.TryParse(input, out tmp)) return false;

            switch (type)
            {
                case "age":
                    {
                        if (tmp > 0 && tmp < 110) return true;
                        else return false;                        
                    }
                    
                case "pet":
                    {
                        if (tmp > 0) return true;
                        else return false;
                    }
                    
                case "color":
                    {
                        if (tmp >= 0) return true;
                        else return false;
                    }
                    
                default: return false;
            }
            
            
        }

        void getName ()
        {
            Console.WriteLine("Ведите свое имя");
            string myName = Console.ReadLine();
            if (myName.Length > 0)
            {
                anketa.name = myName;
            }
            else
            {
                Console.WriteLine("Не верно введено имя");
                getName();
            } 
        };

        void getSurName()
        {
            Console.WriteLine("Ведите свою фамилию");
            string mySurName = Console.ReadLine();
            if (mySurName.Length > 0)
            {
                anketa.surname = mySurName;
            }
            else
            {
                Console.WriteLine("Не верно введена фамилия");
                getSurName();

            } 
        };

        void getAge()
        {
            Console.WriteLine("Ведите свой возраст");
            string myAge = Console.ReadLine();

            if (isCorrectInput(myAge, "age"))
            {
                anketa.age = Int32.Parse(myAge);                
            }
            else
            {
                Console.WriteLine("Не верно введен возраст");
                getAge();
            } 
        };

        void getPetInfo()
        {
            Console.WriteLine("Есть ли у вас питомец? (ответьте да или нет)");
            string havePet = Console.ReadLine();
            anketa.petQuant = 0;
            anketa.petNames = null;

            switch (havePet)
            {
                case "да":
                    {
                        anketa.hasPet = true;
                        Console.WriteLine("Сколько у вас питомцев? ");
                        string myPetQuant = Console.ReadLine();
                        if (isCorrectInput(myPetQuant, "pet"))
                        {
                            anketa.petQuant = Int32.Parse(myPetQuant);
                            
                        }

                        if (anketa.petQuant > 0)
                        {
                            anketa.petNames = getPetNameArray(anketa.petQuant);
                        }
                        break;
                    }
                case "нет":
                    {
                        anketa.hasPet = false;
                        anketa.petQuant = 0;
                        break;
                    }  
                default:
                    {
                        Console.WriteLine("Не верный ответ на вопрос. Есть ли у вас питомцы?");
                        getPetInfo();
                        break;
                    } 
            }
        };

        void getColorInfo()
        {
            Console.WriteLine("Введите количество любимых цветов");
            string myColorQuant = Console.ReadLine();

            if (isCorrectInput(myColorQuant, "color"))
            {
                anketa.favColors = getfavColors(int.Parse(myColorQuant));
            }
            else 
            {
                Console.WriteLine("Не верный ответ на вопрос. Введите количество любимых цветов?");
                getColorInfo();
            }
            
        };

        (string name, string surname, int age, bool hasPet, int petQuant, string[] petNames, string[] favColors) fillAnketa()
        {
            getName();
            getSurName();
            getAge();
            getPetInfo();
            getColorInfo();
            return anketa;
        };

        void showAnketa((string name, string surname, int age, bool hasPet, int petQuant, string[] petNames, string[] favColors) myAnketa)
        {
            Console.WriteLine("Ваше имя: {0}", myAnketa.name);
            Console.WriteLine("Ваша фамилия: {0}", myAnketa.surname);
            Console.WriteLine("Ваш возраст: {0}", myAnketa.age);
            string myHasPet;
            if (myAnketa.hasPet == true)
            {
                myHasPet = "Да"; 
            } else myHasPet = "Нет";
            Console.WriteLine("Есть ли у вас домашние животные: {0}", myHasPet);
            Console.WriteLine("Клички домашних животных в количестве {0}: ", anketa.petQuant);
            foreach (string item in myAnketa.petNames)
            {
                Console.WriteLine(item + ""); 
            }
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (string item in myAnketa.favColors)
            {
                Console.WriteLine(item + "");
            }
        };

        showAnketa(fillAnketa());
        
    }



}