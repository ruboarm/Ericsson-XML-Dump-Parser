using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigCsfbUtra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigCsfbUtra
    {
        [XmlElement(ElementName = "hysteresis", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresis { get; set; }

        [XmlElement(ElementName = "thresholdRscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int thresholdRscp { get; set; }

        [XmlElement(ElementName = "thresholdEcNo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int thresholdEcNo { get; set; }

        [XmlElement(ElementName = "timeToTrigger", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTrigger { get; set; }
    }
}