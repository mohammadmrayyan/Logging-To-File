void Log(string message, LogType logType)
{
    Console.Write($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} ");
    Console.ForegroundColor = logType switch
    {
        LogType.INFO => ConsoleColor.Green,
        LogType.ERROR => ConsoleColor.Red,
        LogType.WARNING => ConsoleColor.Yellow,
        LogType.DEBUG => ConsoleColor.Blue,
        LogType.CRITICAL => ConsoleColor.DarkRed,
        _ => ConsoleColor.White
    };
    Console.Write($"[{logType}]: ".PadLeft(12));
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(message);
}

void LogInformation(string message)
{
    Log(message, LogType.INFO);
    // Console.ForegroundColor = ConsoleColor.Green;
    // Console.Write("[INFO]: ".PadLeft(11));
    // Console.ForegroundColor = ConsoleColor.White;
    // Console.WriteLine(message);
}

void LogError(string message)
{
    Log(message, LogType.ERROR);
    // Console.ForegroundColor = ConsoleColor.Red;
    // Console.Write("[ERROR]: ".PadLeft(11));
    // Console.ForegroundColor = ConsoleColor.White;
    // Console.WriteLine(message);
}

void LogWarning(string message)
{
    Log(message, LogType.WARNING);
    // Console.ForegroundColor = ConsoleColor.Yellow;
    // Console.Write("[WARNING]: ".PadLeft(11));
    // Console.ForegroundColor = ConsoleColor.White;
    // Console.WriteLine(message);
}

int Divide(int a, int b)
{
    try
    {
        LogInformation($"Dividing {a} by {b}");
        int result = a / b;
        LogInformation($"Result: {result}");
        return a / b;
    }
    catch (DivideByZeroException ex)
    {
        LogError(ex.Message);
        return 0;
    }
}


Divide(10, 0);
Divide(10, 2);

LogInformation("Hello, World!");
LogError("Something went wrong!");
LogWarning("Be careful!");
Log("This is a debug message", LogType.DEBUG);
Log("This is a critical message", LogType.CRITICAL);


enum LogType
{
    INFO,
    ERROR,
    WARNING,
    DEBUG,
    CRITICAL,
}