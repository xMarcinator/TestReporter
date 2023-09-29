using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "test-run")]
public class TestRun
{
    [XmlElement(ElementName = "command-line")]
    public string Commandline { get; set; }

    [XmlElement(ElementName = "filter")] public Filter Filter { get; set; }

    [XmlElement(ElementName = "test-suite")]
    public Testsuite Testsuite { get; set; }

    [XmlAttribute(AttributeName = "asserts")]
    public int Asserts { get; set; }

    [XmlAttribute(AttributeName = "clr-version")]
    public string ClrVersion { get; set; }

    [XmlAttribute(AttributeName = "duration")]
    public double Duration { get; set; }

    [XmlAttribute(AttributeName = "end-time")]
    public DateTime EndTime { get; set; }

    [XmlAttribute(AttributeName = "engine-version")]
    public string EngineVersion { get; set; }

    [XmlAttribute(AttributeName = "failed")]
    public int Failed { get; set; }

    [XmlAttribute(AttributeName = "fullname")]
    public string Fullname { get; set; }

    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }

    [XmlAttribute(AttributeName = "inconclusive")]
    public int Inconclusive { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "passed")]
    public int Passed { get; set; }

    [XmlAttribute(AttributeName = "result")]
    public string Result { get; set; }

    [XmlAttribute(AttributeName = "runstate")]
    public string Runstate { get; set; }

    [XmlAttribute(AttributeName = "skipped")]
    public int Skipped { get; set; }

    [XmlAttribute(AttributeName = "start-time")]
    public DateTime StartTime { get; set; }

    [XmlAttribute(AttributeName = "testcasecount")]
    public int Testcasecount { get; set; }

    [XmlAttribute(AttributeName = "total")]
    public int Total { get; set; }

    [XmlAttribute(AttributeName = "warnings")]
    public int Warnings { get; set; }

    [XmlText] public string Text { get; set; }
}