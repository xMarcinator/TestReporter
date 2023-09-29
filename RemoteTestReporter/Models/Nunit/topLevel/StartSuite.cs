using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "start-suite")]
public class StartSuite
{
    [XmlAttribute(AttributeName = "id")] public string Id { get; set; }

    [XmlAttribute(AttributeName = "parentId")]
    public string ParentId { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "fullname")]
    public string Fullname { get; set; }

    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "framework-version")]
    public string FrameworkVersion { get; set; }
}