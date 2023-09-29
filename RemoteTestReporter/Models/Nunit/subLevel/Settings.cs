using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "settings")]
public class Settings
{
    [XmlElement(ElementName = "setting")] public List<Setting> Setting { get; set; }
}