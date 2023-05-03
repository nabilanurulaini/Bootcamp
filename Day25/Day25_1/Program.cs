using NLog;
using System;
class program{
    static void Main(string[] args){
        Logger logger = LogManager.GetCurrentClassLogger();
        
        LogManager.LoadConfiguration(Path.Combine(Directory.GetCurrentDirectory(), "nlog.config"));
        logger.Info("Hello World");
        Console.WriteLine("Hello World");
    }
}