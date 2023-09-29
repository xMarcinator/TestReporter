namespace RemoteTestReporter.Utils;

public class ExtensionLogger : ILogger
{
    StreamWriter file;

    public ExtensionLogger()
    {
        file = File.AppendText("C:\\Users\\Marc\\RiderProjects\\RemoteTestReporter\\RemoteTestReporter\\log.txt");

        file.AutoFlush = true;
    }

    public void WriteLine()
    {
        file.WriteLine();
    }

    public void WriteLine(string line)
    {
        file.WriteLine(line);
    }

    public void Write(string line)
    {
        file.Write(line);
    }
}