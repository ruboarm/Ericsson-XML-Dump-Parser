using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigB2GeranUlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigB2GeranUlTrig
    {
        [XmlElement(ElementName = "b2Threshold2Geran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2Geran { get; set; }

        [XmlElement(ElementName = "timeToTriggerB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerB2 { get; set; }

        [XmlElement(ElementName = "reportIntervalB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int reportIntervalB2 { get; set; }

        [XmlElement(ElementName = "hysteresisB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisB2 { get; set; }
    }
}