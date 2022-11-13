using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigB1Utra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigB1Utra
    {
        [XmlElement(ElementName = "b1ThresholdRscpUtra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b1ThresholdRscpUtra { get; set; }

        [XmlElement(ElementName = "timeToTriggerB1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerB1 { get; set; }

        [XmlElement(ElementName = "hysteresisB1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisB1 { get; set; }

        [XmlElement(ElementName = "b1ThresholdEcNoUtra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b1ThresholdEcNoUtra { get; set; }
    }
}