﻿using System.Xml.Serialization;

namespace RemoteTestReporter.DataModels;

[XmlRoot(ElementName = "test-suite")]
public class Testsuite
{
    [XmlElement(ElementName = "testcase")] public List<Testcase> Testcase { get; set; }

    [XmlAttribute(AttributeName = "asserts")]
    public int Asserts { get; set; }

    [XmlAttribute(AttributeName = "classname")]
    public string Classname { get; set; }

    [XmlAttribute(AttributeName = "duration")]
    public double Duration { get; set; }

    [XmlAttribute(AttributeName = "end-time")]
    public DateTime EndTime { get; set; }

    [XmlAttribute(AttributeName = "failed")]
    public int Failed { get; set; }

    [XmlAttribute(AttributeName = "fullname")]
    public string Fullname { get; set; }

    [XmlAttribute(AttributeName = "id")] public string Id { get; set; }

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

    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "warnings")]
    public int Warnings { get; set; }

    [XmlText] public string Text { get; set; }

    [XmlElement(ElementName = "testsuite")]
    public List<Testsuite> SubTestsuites { get; set; }

    [XmlElement(ElementName = "environment")]
    public Environment Environment { get; set; }

    [XmlElement(ElementName = "settings")] public Settings Settings { get; set; }

    [XmlElement(ElementName = "properties")]
    public Properties Properties { get; set; }
}

[XmlRoot(ElementName = "test-suite")]
public class TestSuite
{
    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "id")] public string Id { get; set; }

    [XmlAttribute(AttributeName = "name")] public string Name { get; set; }

    [XmlAttribute(AttributeName = "fullname")]
    public string Fullname { get; set; }

    [XmlAttribute(AttributeName = "classname")]
    public string Classname { get; set; }

    [XmlAttribute(AttributeName = "runstate")]
    public string Runstate { get; set; }

    [XmlAttribute(AttributeName = "testcasecount")]
    public int Testcasecount { get; set; }

    [XmlAttribute(AttributeName = "result")]
    public string Result { get; set; }

    [XmlAttribute(AttributeName = "start-time")]
    public DateTime StartTime { get; set; }

    [XmlAttribute(AttributeName = "end-time")]
    public DateTime EndTime { get; set; }

    [XmlAttribute(AttributeName = "duration")]
    public double Duration { get; set; }

    [XmlAttribute(AttributeName = "total")]
    public int Total { get; set; }

    [XmlAttribute(AttributeName = "passed")]
    public int Passed { get; set; }

    [XmlAttribute(AttributeName = "failed")]
    public int Failed { get; set; }

    [XmlAttribute(AttributeName = "warnings")]
    public int Warnings { get; set; }

    [XmlAttribute(AttributeName = "inconclusive")]
    public int Inconclusive { get; set; }

    [XmlAttribute(AttributeName = "skipped")]
    public int Skipped { get; set; }

    [XmlAttribute(AttributeName = "asserts")]
    public int Asserts { get; set; }

    [XmlAttribute(AttributeName = "parentId")]
    public string ParentId { get; set; }
}