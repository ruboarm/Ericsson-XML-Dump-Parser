using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigB2UtraUlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigB2UtraUlTrig
    {
        [XmlElement(ElementName = "vsDataReportConfigB2UtraUlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2EcNoUtra { get; set; }

        [XmlElement(ElementName = "b2Threshold2RscpUtra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2RscpUtra { get; set; }

        [XmlElement(ElementName = "timeToTriggerB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerB2 { get; set; }

        [XmlElement(ElementName = "reportIntervalB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int reportIntervalB2 { get; set; }

        [XmlElement(ElementName = "hysteresisB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisB2 { get; set; }
    }
}