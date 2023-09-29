using System.Globalization;
using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "start-run")]
public class StartRun
{
    [XmlElement(ElementName = "command-line")]
    public string Commandline { get; set; }

    [XmlAttribute(AttributeName = "count")]
    public int Count { get; set; }

    [XmlIgnore] public DateTime StartTime { get; set; }

    [XmlAttribute(AttributeName = "start-time")]
    public string StartTimeString
    {
        get { return StartTime.ToString("yyyy-MM-dd hh:mm:ssZ"); }
        set { StartTime = DateTime.ParseExact(value, "yyyy-MM-dd hh:mm:ssZ", new CultureInfo("en-US")); }
    }

    [XmlAttribute(AttributeName = "engine-version")]
    public string EngineVersion { get; set; }

    [XmlAttribute(AttributeName = "clr-version")]
    public string ClrVersion { get; set; }

    [XmlText] public string Text { get; set; }
}