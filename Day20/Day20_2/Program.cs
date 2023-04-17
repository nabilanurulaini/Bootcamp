using System;
using System.IO;
using System.Text;
using System.IO.Compression;
class ProgramFileStream
{
    static void Main(){
        string path = @"C:\Users\Formulatrix\Documents\GitHub\Bootcamp\Day20\Day20_2\test.txt";
        
        //filemode open or create jika file tidak ada maka akan dibuatkan file baru
        //fileaccess readwrite untuk membaca dan menulis
        using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            Console.WriteLine("Input your text here: ");
            string text = Console.ReadLine();
            byte[] data = Encoding.UTF8.GetBytes(text);
            fs.Write(data, 0, data.Length);
            fs.Close();
        }
        //zip file
        //extract file
        //ZipFile.ExtractToDirectory(zipPath, extractPath);
        
    }File.Delete(fileName);
}