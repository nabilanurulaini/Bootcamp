using NLog;

namespace FooBar
{
    public class Logger
    {
        private static readonly ILogger logger = LogManager.GetCurrentClassLogger();
        
        public static void Info(string message)
        {
            
        LogManager.LoadConfiguration(Path.Combine(Directory.GetCurrentDirectory(), "nlog.config"));
            logger.Info(message);
        }

        public static void Warn(string message)
        {
            logger.Warn(message);
        }

        public static void Error(string message)
        {
            logger.Error(message);
        }
        public static void Debug(string message)
        {
            logger.Debug(message);
        }
    }
}
