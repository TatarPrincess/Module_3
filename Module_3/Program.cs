//using System;
//using System.ComponentModel;
//using System.Diagnostics;
//using System.Diagnostics.Metrics;
//using System.Drawing;
//using System.Globalization;
//using System.Xml.Linq;
//using System.IO;
//namespace DriveManager;
namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs(); //   Вызов метода получения директорий
        }

        static void GetCatalogs()
        {
            string dirName = @"/"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);
                

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);

                getQuantity(files, "file");
                getQuantity(dirs, "directory");

                string pathMasha = @"C:\Users\xiaomi\Desktop/testFolder";
                if (Directory.Exists(pathMasha))
                {
                    Console.WriteLine("Already exists");                
                } else Directory.CreateDirectory(pathMasha);

                string newPath = @"C:\$Recycle.Bin";

                if (Directory.Exists(pathMasha)) Console.WriteLine("Директория Маша существует");
                if (!Directory.Exists(newPath)) Console.WriteLine("Директория новая не существует");
                if (Directory.Exists(pathMasha) && !Directory.Exists(newPath))
                    Directory.Move(pathMasha, newPath);

                void getQuantity(string[] objs, string type)
                {
                    if (type == "file")
                    {
                        Console.WriteLine("Количество файлов в корне: {0}", files.Length);
                    }
                    else if (type == "directory")
                    {
                        Console.WriteLine("Количество каталогов в корне: {0}", dirs.Length);
                    }
                }
            }
        }

        
    }
}


//class SystemDisc
//{
//    private string name;
//    private long capacity;
//    private long freeSpace;
//    protected Dictionary<string, Folder> folderList =  new Dictionary<string, Folder>();
//    public string Name 
//    {
//        get => name;
//        set => name = value;
//    }
//    public long Capacity
//    { 
//       get => capacity;
//       set => capacity = value;
//    }
//    public long FreeSpace
//    {
//        get => freeSpace;
//        set => freeSpace = value;
//    }

//    public SystemDisc(string name, long capacity, long freeSpace)
//    { 
//        Name = name;
//        Capacity = capacity;
//        FreeSpace = freeSpace;
//    }

//    public class Folder
//    {
//        private string name;
//        public List<string> Files { get; set; } = new List<string>();
//        public string Name { get; set; }
//        public Folder(string name)
//        {
//            Name = name;
//        }
//    }

//    public void AddNewFolder(string name)
//    { 
//      Folder folder = new Folder(name);
//      folderList.Add(name, folder);
//        Console.WriteLine("Папка успешно создана");
//    }

//}


