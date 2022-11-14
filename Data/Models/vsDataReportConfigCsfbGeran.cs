using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigCsfbGeran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigCsfbGeran
    {
        [XmlElement(ElementName = "thresholdGeran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int thresholdGeran { get; set; }

        [XmlElement(ElementName = "hysteresis", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresis { get; set; }

        [XmlElement(ElementName = "timeToTrigger", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTrigger { get; set; }
    }
}