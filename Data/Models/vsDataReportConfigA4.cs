using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigA4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigA4
    {
        [XmlElement(ElementName = "hysteresisA4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA4 { get; set; }

        [XmlElement(ElementName = "a4ThresholdRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a4ThresholdRsrq { get; set; }

        [XmlElement(ElementName = "timeToTriggerA4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA4 { get; set; }

        [XmlElement(ElementName = "a4ThresholdRsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a4ThresholdRsrp { get; set; }

        [XmlElement(ElementName = "triggerQuantityA4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int triggerQuantityA4 { get; set; }
    }
}