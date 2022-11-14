using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigCsfbCdma2000", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigCsfbCdma2000
    {
        [XmlElement(ElementName = "hysteresis", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresis { get; set; }

        [XmlElement(ElementName = "thresholdCdma20001xRtt", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int thresholdCdma20001xRtt { get; set; }

        [XmlElement(ElementName = "timeToTrigger", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTrigger { get; set; }
    }
}