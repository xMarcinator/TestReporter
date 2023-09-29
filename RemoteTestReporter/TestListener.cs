using System.Text;
using System.Xml.Serialization;
using NUnit.Engine;
using NUnit.Engine.Extensibility;
using RemoteTestReporter.DataModels;
using RemoteTestReporter.Utils;

namespace RemoteTestReporter;

[Extension(Description = "Event Listener Extension")]
public class TestListener : ITestEventListener
{
    private ILogger logger;

    public TestListener() : this(new ExtensionLogger())
    {
    }

    public TestListener(ILogger logger)
    {
        this.logger = logger;
    }

    public void OnTestEvent(string report)
    {
        Console.WriteLine("hello");
        var enumerator = report.GetEnumerator();

        //skip the start "<" in xml
        enumerator.MoveNext();

        StringBuilder stringBuilder = new StringBuilder(10);

        while (enumerator.MoveNext() && !enumerator.Current.Equals(' '))
        {
            stringBuilder.Append(enumerator.Current);
        }

        switch (stringBuilder.ToString())
        {
            case "start-run":
                handleStartRun(report);
                break;
            case "test-case":
                handleTestCase(report);
                break;
            case "test-suite":
                handleTestSuite(report);
                break;
            case "start-suite":
                handleStartSuite(report);
                break;
            case "start-test":
                handleStartTest(report);
                break;
            case "test-run":
                handleTestRun(report);
                break;
            default:
                logger.WriteLine("unhandled case");
                break;
        }

        logger.WriteLine(report);

        logger.WriteLine("-----------------------------------------");
    }

    private void handleTestRun(string report)
    {
        var testCaseDescriptor = parseXML<TestRun>(report);
        if (testCaseDescriptor.Equals(null))
            return;
    }

    private void handleStartTest(string report)
    {
        var testCaseDescriptor = parseXML<StartTest>(report);
        if (testCaseDescriptor.Equals(null))
            return;
    }

    private void handleStartSuite(string report)
    {
        var testCaseDescriptor = parseXML<StartSuite>(report);
        if (testCaseDescriptor.Equals(null))
            return;

        logger.WriteLine(testCaseDescriptor.Name);
    }

    private void handleTestSuite(string report)
    {
        var testCaseDescriptor = parseXML<TestSuite>(report);
        if (testCaseDescriptor.Equals(null))
            return;

        logger.WriteLine(testCaseDescriptor.StartTime.ToString());
    }

    private void handleTestCase(string report)
    {
        TestCase testCaseDescriptor = parseXML<TestCase>(report);
        if (testCaseDescriptor.Equals(null))
            return;

        foreach (var property in testCaseDescriptor.Properties.Property)
        {
            logger.WriteLine(property.Name + "=" + property.Value);
        }
    }

    private void handleStartRun(String report)
    {
        StartRun startRunDescriptor = parseXML<StartRun>(report);
        if (startRunDescriptor.Equals(null))
            return;

        logger.WriteLine(startRunDescriptor.StartTime.ToString());
    }


    private T parseXML<T>(String xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        T? startRunDescriptor;

        using (TextReader reader = new StringReader(xml))
        {
            startRunDescriptor = (T?)serializer.Deserialize(reader);
        }

        return startRunDescriptor;
    }
}