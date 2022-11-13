using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigA5UlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigA5UlTrig
    {
        [XmlElement(ElementName = "timeToTriggerA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA5 { get; set; }

        [XmlElement(ElementName = "hysteresisA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA5 { get; set; }

        [XmlElement(ElementName = "a5Threshold2Rsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2Rsrp { get; set; }

        [XmlElement(ElementName = "reportIntervalA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int reportIntervalA5 { get; set; }
    }
}