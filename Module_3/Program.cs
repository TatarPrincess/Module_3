using System;

class Programme
{
    static void Main(string[] args)
    {
        string path = @"C:/Users/xiaomi/Desktop/BinaryFile.bin";
        
        WriteString(path);
        ReadString(path);
    }

    static void WriteString(string path)
    {
        FileInfo fileInfo = new FileInfo(path);
        Stream stream = fileInfo.Open(FileMode.Open);
        if (fileInfo.Exists)
        {
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                DateTime now = DateTime.Now;
                OperatingSystem os = Environment.OSVersion;
                string strToWrite = "Файл изменен " + now + "на компьютере " + os;
                writer.Write(strToWrite);   

            }
        }
    }

    static void ReadString(string path)
    {
        FileInfo fileInfo = new FileInfo(path);
        Stream stream = fileInfo.Open(FileMode.Open);
        if (fileInfo.Exists)
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                string str = reader.ReadString();
                Console.WriteLine(str);

            }
        }
    }
}


