using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "filter")]
public class Filter
{
    [XmlElement(ElementName = "id")] public string Id { get; set; }
}