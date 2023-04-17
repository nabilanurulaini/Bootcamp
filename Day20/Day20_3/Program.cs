using System.IO;
using System.IO.Compression;
using System;
using System.Diagnostics;

Console.WriteLine("Input your text here: ");
string inputString = Console.ReadLine();
string fileName = "test.txt";
string zipFileName = "test.zip";
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
// Write the string to a file
using (StreamWriter writer = new StreamWriter(fileName))
{
    writer.Write(inputString);
}

// Create a file stream for the input file. usercan only open/read aja not write
using (FileStream inputStream = new FileStream(fileName, FileMode.Open))
{
    // Create a file stream for the output zip file dari zipFileName
    using (FileStream outputStream = new FileStream(zipFileName, FileMode.Create))
    {
        // Create a zip archive
        using (ZipArchive archive = new ZipArchive(outputStream, ZipArchiveMode.Create))
        {
            // Create a zip entry for the input file
            ZipArchiveEntry entry = archive.CreateEntry(fileName);

            // memasukka isi dari input file ke dalam zip file
            using (Stream entryStream = entry.Open())
            {
                inputStream.CopyTo(entryStream);
                //unzip file
               // ZipFile.ExtractToDirectory(zipFileName, "unzip");
            }
        }
    }
}
stopWatch.Stop();
Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);

// Delete the input file, jadi setiap kita run program ini, maka file test.txt akan dihapus

