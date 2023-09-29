using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "test-case")]
public class Testcase
{
    [XmlElement(ElementName = "properties")]
    public Properties Properties { get; set; }

    [XmlElement(ElementName = "output")] public string Output { get; set; }

    [XmlAttribute(AttributeName = "asserts")]
    public int Asserts { get; set; }

    [XmlAttribute(AttributeName = "classname")]
    public string Classname { get; set; }

    [XmlAttribute(AttributeName = "duration")]
    public double Duration { get; set; }

    [XmlAttribute(AttributeName = "end-time")]
    public DateTime EndTime { get; set; }

    [XmlAttribute(AttributeName = "fullname")]
    public string Fullname { get; set; }

    [XmlAttribute(AttributeName = "id")] public string Id { get; set; }

    [XmlAttribute(AttributeName = "methodname")]
    public string Methodname { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "result")]
    public string Result { get; set; }

    [XmlAttribute(AttributeName = "runstate")]
    public string Runstate { get; set; }

    [XmlAttribute(AttributeName = "seed")] public int Seed { get; set; }

    [XmlAttribute(AttributeName = "start-time")]
    public DateTime StartTime { get; set; }

    [XmlText] public string Text { get; set; }
}

[XmlRoot(ElementName = "test-case")]
public class TestCase
{
    [XmlElement(ElementName = "properties")]
    public Properties Properties { get; set; }

    [XmlElement(ElementName = "output")] public string Output { get; set; }

    [XmlAttribute(AttributeName = "id")] public string Id { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "fullname")]
    public string Fullname { get; set; }

    [XmlAttribute(AttributeName = "methodname")]
    public string Methodname { get; set; }

    [XmlAttribute(AttributeName = "classname")]
    public string Classname { get; set; }

    [XmlAttribute(AttributeName = "runstate")]
    public string Runstate { get; set; }

    [XmlAttribute(AttributeName = "seed")] public int Seed { get; set; }

    [XmlAttribute(AttributeName = "result")]
    public string Result { get; set; }

    [XmlAttribute(AttributeName = "start-time")]
    public DateTime StartTime { get; set; }

    [XmlAttribute(AttributeName = "end-time")]
    public DateTime EndTime { get; set; }

    [XmlAttribute(AttributeName = "duration")]
    public double Duration { get; set; }

    [XmlAttribute(AttributeName = "asserts")]
    public int Asserts { get; set; }

    [XmlAttribute(AttributeName = "parentId")]
    public string ParentId { get; set; }

    [XmlText] public string Text { get; set; }
}