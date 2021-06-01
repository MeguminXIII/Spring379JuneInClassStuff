using Microsoft.Extensions.Logging;
using Serilog;

namespace InClassConsoleApp
{
    public class Logging
    {

        public static ILoggerFactory MyLoggerFactory {get; set;}
        public Microsoft.Extensions.Logging.ILogger Logger { get; } = Logging.MyLoggerFactory.CreateLogger<Logging>();

        public void LogStuff()
        {
             Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("log.txt")
                .CreateLogger();
                        
                MyLoggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .AddSerilog(logger: Log.Logger)
                        .AddFilter("Microsoft", LogLevel.Warning)
                        .AddFilter("System", LogLevel.Warning)
                        .AddFilter("LoggingConsoleApp.Program", LogLevel.Debug)
                        .AddConsole()
                        .AddEventLog();
                });

            //Microsoft.Extensions.Logging.ILogger logger = LoggerFactory.CreateLogger<Logging>();

            Logger.LogDebug("This is a Debugging log message");
            Logger.LogTrace("This is a Trace log message");        
            Logger.LogInformation("This is an Information log message");
            Logger.LogWarning("This is a Warning log message");
            Logger.LogError("This is an Error log message");
            Logger.LogCritical("This is a Critical log message");

            //logger.Log(LogLevel.Debug,);

            //put the Microsoft.Extensions.Logging using statement into the class that wants to log stuff and pass in the logger via constructor
        
            LoggingEx logTest = new LoggingEx();
            logTest.LogStuff();
        }
    }
}