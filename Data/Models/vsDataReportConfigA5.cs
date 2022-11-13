using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigA5
    {
        [XmlElement(ElementName = "timeToTriggerA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA5 { get; set; }

        [XmlElement(ElementName = "a5Threshold2Rsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2Rsrq { get; set; }

        [XmlElement(ElementName = "hysteresisA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA5 { get; set; }

        [XmlElement(ElementName = "a5Threshold2Rsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2Rsrp { get; set; }

        [XmlElement(ElementName = "a5Threshold1Rsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold1Rsrq { get; set; }

        [XmlElement(ElementName = "a5Threshold1Rsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold1Rsrp { get; set; }

        [XmlElement(ElementName = "triggerQuantityA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int triggerQuantityA5 { get; set; }

        [XmlElement(ElementName = "hysteresisA5RsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA5RsrqOffset { get; set; }

        [XmlElement(ElementName = "timeToTriggerA5Rsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA5Rsrq { get; set; }
    }
}