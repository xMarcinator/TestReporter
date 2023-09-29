using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "environment")]
public class Environment
{
    [XmlAttribute(AttributeName = "clr-version")]
    public string ClrVersion { get; set; }

    [XmlAttribute(AttributeName = "culture")]
    public string Culture { get; set; }

    [XmlAttribute(AttributeName = "cwd")] public string Cwd { get; set; }

    [XmlAttribute(AttributeName = "framework-version")]
    public string FrameworkVersion { get; set; }

    [XmlAttribute(AttributeName = "machine-name")]
    public string MachineName { get; set; }

    [XmlAttribute(AttributeName = "os-architecture")]
    public string OsArchitecture { get; set; }

    [XmlAttribute(AttributeName = "os-version")]
    public string OsVersion { get; set; }

    [XmlAttribute(AttributeName = "platform")]
    public string Platform { get; set; }

    [XmlAttribute(AttributeName = "uiculture")]
    public string Uiculture { get; set; }

    [XmlAttribute(AttributeName = "user")] public string User { get; set; }

    [XmlAttribute(AttributeName = "user-domain")]
    public string UserDomain { get; set; }
}