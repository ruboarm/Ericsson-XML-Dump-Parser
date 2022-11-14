using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigEUtraBadCovPrim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigEUtraBadCovPrim
    {
        [XmlElement(ElementName = "hysteresisA2Prim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA2Prim { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2Prim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2Prim { get; set; }

        [XmlElement(ElementName = "a2ThresholdRsrpPrim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrpPrim { get; set; }

        [XmlElement(ElementName = "triggerQuantityA2Prim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int triggerQuantityA2Prim { get; set; }

        [XmlElement(ElementName = "a2ThresholdRsrqPrim", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrqPrim { get; set; }
    }
}