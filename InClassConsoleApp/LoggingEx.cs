using Microsoft.Extensions.Logging;

namespace InClassConsoleApp
{
    public class LoggingEx
    {
        public ILogger Logger { get; } = Logging.MyLoggerFactory.CreateLogger<LoggingEx>();
        
        public void LogStuff()
        {
            Logger.LogInformation("Info from another file");
            Logger.LogWarning("Warning from another file");
        }


    }    
}