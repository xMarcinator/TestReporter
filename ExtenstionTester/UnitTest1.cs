using ExtenstionTester.Utils;
using RemoteTestReporter;

namespace ExtenstionTester;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test, Property("Location", 723)]
    public void Test1()
    {
        TestListener listener = new TestListener(new ConsoleLogger());

        listener.OnTestEvent(
            "<start-run count=\"1\" start-time=\"2023-06-27 07:00:18Z\" engine-version=\"3.15.3.0\" clr-version=\"7.0.7\"><command-line><![CDATA[\"C:\\Program Files\\JetBrains\\Rider\\r2r\\2023.1.3R\\FB5A4954A2B5B096078EBC40157DCB6\\TestRunner\\netcoreapp3.0\\ReSharperTestRunner.dll\" --parentProcessId 20728 -p 52341 -r 3c9fbfc3-dab9-4caa-ba74-b3e01b6c2224]]></command-line></start-run>");
    }

    [Test, Property("Location", 723)]
    public void Test2()
    {
        TestListener listener = new TestListener(new ConsoleLogger());

        listener.OnTestEvent(
            "<start-run count=\"1\" start-time=\"2023-06-27 07:00:18Z\" engine-version=\"3.15.3.0\" clr-version=\"7.0.7\"><command-line><![CDATA[\"C:\\Program Files\\JetBrains\\Rider\\r2r\\2023.1.3R\\FB5A4954A2B5B096078EBC40157DCB6\\TestRunner\\netcoreapp3.0\\ReSharperTestRunner.dll\" --parentProcessId 20728 -p 52341 -r 3c9fbfc3-dab9-4caa-ba74-b3e01b6c2224]]></command-line></start-run>");
    }
}