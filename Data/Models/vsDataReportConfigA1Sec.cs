using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigA1Sec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigA1Sec
    {
        [XmlElement(ElementName = "hysteresisA1Sec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA1Sec { get; set; }

        [XmlElement(ElementName = "a1ThresholdRsrpSec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrpSec { get; set; }

        [XmlElement(ElementName = "timeToTriggerA1Sec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA1Sec { get; set; }

        [XmlElement(ElementName = "a1ThresholdRsrqSec", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrqSec { get; set; }
    }
}