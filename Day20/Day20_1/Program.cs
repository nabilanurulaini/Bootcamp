using System;
using System.IO;
using System.Text;
class ProgramFileStream
{
    static void Main(){
        string path = @"C:\Users\HP\Bootcamp\Day20\Day20_1\TextFile1.txt";
        //filemode open or create jika file tidak ada maka akan dibuatkan file baru
        //fileaccess readwrite untuk membaca dan menulis
        FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        Console.WriteLine("Input your text here: ");
        string text = Console.ReadLine();
        byte[] data = Encoding.ASCII.GetBytes(text);
        fs.Write(data, 0, data.Length);
        fs.Close();
    }

   
    
}