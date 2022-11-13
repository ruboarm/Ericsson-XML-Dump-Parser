using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigB1Geran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigB1Geran
    {
        [XmlElement(ElementName = "timeToTriggerB1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerB1 { get; set; }

        [XmlElement(ElementName = "b1ThresholdGeran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b1ThresholdGeran { get; set; }

        [XmlElement(ElementName = "hysteresisB1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisB1 { get; set; }
    }
}