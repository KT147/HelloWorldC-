using System.ComponentModel;

public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // @ märk võtab stringi nii nagu on
        string directoryPath = "/Users/atla/Logs";
        string filePath = Path.Combine(directoryPath, "log.txt");
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        File.AppendAllText(filePath, message);
    }
}

public class DataBaseLogger : ILogger
{
    public void Log(string message)
    {
        System.Console.WriteLine("Logging to database: " + message);
        //todo log a message to DB
    }
}

public class Application
{
    private readonly ILogger _logger;
    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        _logger.Log("Work started");
        // do all the work
        _logger.Log("Work done");
    }
}

