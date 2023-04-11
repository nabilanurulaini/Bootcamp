using System;
using System.IO;
using System.Text;

class Text{
    public static void Main()
    {
        string path = @"C:\Users\Formulatrix\Documents\GitHub\Bootcamp\Day12\WriteText.txt";
        string text = "Hello Ayam";
        // //this will create a file based on the path dan write text yang ada dalam var text
        // File.WriteAllText(path, text);
        // //if succeded will give message file created
        // Console.WriteLine("File created");

        // check file jika exist maka delete
        if( File.Exists(path))
        {
            File.Delete(path);
        }
        using (StreamWriter sw = File.CreateText(path))
        {
           for(int i =0; i<= 10000; i++)
           {
                sw.WriteLine(i+text);
           }
        }
        //this will read the file and print it
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
        Console.ReadLine();
        
    }
}