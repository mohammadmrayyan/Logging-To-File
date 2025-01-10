# Logging to File Project

## Project Overview

This C# project demonstrates a simple logging system that logs messages to the console with different log levels, including `INFO`, `ERROR`, `WARNING`, `DEBUG`, and `CRITICAL`. Each log message is prefixed with a timestamp and formatted using appropriate colors to differentiate log types visually.

## Features

- Logs messages with timestamps to the console.
- Supports multiple log types:
  - `INFO`: Informational messages (green)
  - `ERROR`: Error messages (red)
  - `WARNING`: Warning messages (yellow)
  - `DEBUG`: Debugging messages (blue)
  - `CRITICAL`: Critical error messages (dark red)

## Example Usage

### Code Snippet

```csharp
int Divide(int a, int b)
{
    try
    {
        LogInformation($"Dividing {a} by {b}");
        int result = a / b;
        LogInformation($"Result: {result}");
        return result;
    }
    catch (DivideByZeroException ex)
    {
        LogError(ex.Message);
        return 0;
    }
}

Divide(10, 0);
Divide(10, 2);
```

### Console Output Example

```
2025-01-11 00:05:46     [INFO]: Dividing 10 by 0
2025-01-11 00:05:46    [ERROR]: Attempted to divide by zero.
2025-01-11 00:05:46     [INFO]: Dividing 10 by 2
2025-01-11 00:05:46     [INFO]: Result: 5
```

## Log Types

The `LogType` enumeration defines the following log levels:

```csharp
enum LogType
{
    INFO,
    ERROR,
    WARNING,
    DEBUG,
    CRITICAL,
}
```

## License

This project is available for educational and personal use. Modify and adapt as needed for your applications.
