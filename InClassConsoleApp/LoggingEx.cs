using Microsoft.Extensions.Logging;

namespace InClassConsoleApp
{
    public class LoggingEx{

        public ILogger Logger { get; }

        public LoggingEx(ILogger logger){
            Logger = logger;
            Logger.LogDebug("this is a debug from a different file");
            
        }


    }    
}