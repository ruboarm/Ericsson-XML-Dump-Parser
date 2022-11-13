using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigB2Cdma2000", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigB2Cdma2000
    {
        [XmlElement(ElementName = "b2Threshold2Cdma2000", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2Cdma2000 { get; set; }

        [XmlElement(ElementName = "b2Threshold1Rsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1Rsrq { get; set; }

        [XmlElement(ElementName = "b2Threshold1Rsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1Rsrp { get; set; }

        [XmlElement(ElementName = "timeToTriggerB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerB2 { get; set; }

        [XmlElement(ElementName = "hysteresisB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisB2 { get; set; }

        [XmlElement(ElementName = "triggerQuantityB2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int triggerQuantityB2 { get; set; }

        [XmlElement(ElementName = "timeToTriggerB2Rsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerB2Rsrq { get; set; }

        [XmlElement(ElementName = "hysteresisB2RsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisB2RsrqOffset { get; set; }
    }
}