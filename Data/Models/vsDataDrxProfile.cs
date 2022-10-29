using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataDrxProfile", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataDrxProfile
    {
        [XmlElement(ElementName = "longDrxCycleOnly", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int longDrxCycleOnly { get; set; }

        [XmlElement(ElementName = "drxRetransmissionTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int drxRetransmissionTimer { get; set; }

        [XmlElement(ElementName = "drxInactivityTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int drxInactivityTimer { get; set; }

        [XmlElement(ElementName = "longDrxCycle", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int longDrxCycle { get; set; }

        [XmlElement(ElementName = "shortDrxCycle", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int shortDrxCycle { get; set; }

        [XmlElement(ElementName = "onDurationTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int onDurationTimer { get; set; }

        [XmlElement(ElementName = "shortDrxCycleTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int shortDrxCycleTimer { get; set; }

        [XmlElement(ElementName = "drxState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int drxState { get; set; }
    }
}