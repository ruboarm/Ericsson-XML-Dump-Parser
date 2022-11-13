using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigA5Anr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigA5Anr
    {
        [XmlElement(ElementName = "timeToTriggerA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA5 { get; set; }

        [XmlElement(ElementName = "hysteresisA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA5 { get; set; }

        [XmlElement(ElementName = "a5Threshold1RsrqAnrDelta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold1RsrqAnrDelta { get; set; }

        [XmlElement(ElementName = "a5Threshold2RsrpAnrDelta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2RsrpAnrDelta { get; set; }

        [XmlElement(ElementName = "a5Threshold1RsrpAnrDelta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold1RsrpAnrDelta { get; set; }

        [XmlElement(ElementName = "a5Threshold2RsrqAnrDelta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2RsrqAnrDelta { get; set; }
    }
}