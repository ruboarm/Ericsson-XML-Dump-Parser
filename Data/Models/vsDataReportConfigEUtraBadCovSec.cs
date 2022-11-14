using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigEUtraBadCovSec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigEUtraBadCovSec
    {
        [XmlElement(ElementName = "a2ThresholdRsrqSec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrqSec { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2Sec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2Sec { get; set; }

        [XmlElement(ElementName = "a2ThresholdRsrpSec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrpSec { get; set; }

        [XmlElement(ElementName = "hysteresisA2Sec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA2Sec { get; set; }

        [XmlElement(ElementName = "triggerQuantityA2Sec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int triggerQuantityA2Sec { get; set; }
    }
}