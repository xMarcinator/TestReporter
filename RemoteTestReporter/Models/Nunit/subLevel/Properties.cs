using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "properties")]
public class Properties
{
    [XmlElement(ElementName = "property")] public List<Property> Property { get; set; }
}