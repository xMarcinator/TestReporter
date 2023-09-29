using RemoteTestReporter;

namespace ExtenstionTester.Utils;

public class ConsoleLogger : ILogger
{
    public void WriteLine()
    {
        Console.WriteLine();
    }

    public void WriteLine(string line)
    {
        Console.WriteLine(line);
    }

    public void Write(string line)
    {
        Console.Write(line);
    }
}