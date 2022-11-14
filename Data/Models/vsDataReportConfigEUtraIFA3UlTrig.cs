using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigEUtraIFA3UlTrig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigEUtraIFA3UlTrig
    {
        [XmlElement(ElementName = "hysteresisA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA3 { get; set; }

        [XmlElement(ElementName = "timeToTriggerA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA3 { get; set; }

        [XmlElement(ElementName = "reportIntervalA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int reportIntervalA3 { get; set; }

        [XmlElement(ElementName = "a3Offset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a3Offset { get; set; }
    }
}