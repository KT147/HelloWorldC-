using System.Runtime.InteropServices;

public class DelegateExample
{
    public delegate void Notify(string message);

    public static void ShowMessage(string message)
    {
        System.Console.WriteLine(message);
    }

}

public class Logger
{

    public delegate void LogHandler(string Mmssage);

    public void LogToConsole(string message)
    {
        System.Console.WriteLine("Console log: " + message);
    }

    public void LogToFile(string message)
    {
        System.Console.WriteLine("File log: " + message);
    }

    public void InvokeSafely(LogHandler logHandler, string message)
    {
        LogHandler tempLogHandler = logHandler;
        if (tempLogHandler != null)
        {
            tempLogHandler(message);
        }
    }

    public bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
    {
        if (logHandler == null)
            return false;

        foreach (Delegate d in logHandler.GetInvocationList())
        {
            if (d.Equals(method))
                return true;
        }

        return false;
    }

}



