namespace RemoteTestReporter;

public interface ILogger
{
    public void WriteLine();
    public void WriteLine(String line);
    public void Write(String line);
}