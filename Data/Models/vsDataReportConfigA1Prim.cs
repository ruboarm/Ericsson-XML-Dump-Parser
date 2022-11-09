using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigA1Prim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigA1Prim
    {
        [XmlElement(ElementName = "timeToTriggerA1Prim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA1Prim { get; set; }

        [XmlElement(ElementName = "hysteresisA1Prim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA1Prim { get; set; }

        [XmlElement(ElementName = "a1ThresholdRsrqPrim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrqPrim { get; set; }

        [XmlElement(ElementName = "a1ThresholdRsrpPrim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrpPrim { get; set; }
    }
}