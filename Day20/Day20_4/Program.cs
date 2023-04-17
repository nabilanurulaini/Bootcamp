using System;
using System.IO;
using System.Text;
using System.IO.Compression;
using System.Diagnostics;
class ProgramFileStream
{
    static void Main(){
        string path = @"C:\Users\Formulatrix\Documents\GitHub\Bootcamp\Day20\Day20_4\test.txt";
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        //filemode open or create jika file tidak ada maka akan dibuatkan file baru
        //fileaccess readwrite untuk membaca dan menulis
        using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            Console.WriteLine("Input your text here: ");
            string text = Console.ReadLine();
            byte[] data = Encoding.UTF8.GetBytes(text);
            fs.Write(data, 0, data.Length);
            //to zip file
            string zipPath = @"C:\Users\Formulatrix\Documents\GitHub\Bootcamp\Day20\Day20_4\test.zip";
            using(FileStream zipFs = new FileStream(zipPath, FileMode.Create))
            {
                
                using(ZipArchive zipArchive = new ZipArchive(zipFs, ZipArchiveMode.Create))
                {
                    ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry("test.txt");
                    using(Stream zipStream = zipArchiveEntry.Open())
                    {
                        fs.(zipStream);
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
        }
       
    }
}