using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataRcs", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataRcs
    {
        [XmlElement(ElementName = "tInactivityTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tInactivityTimer { get; set; }

        [XmlElement(ElementName = "rlcDlDeliveryFailureAction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int rlcDlDeliveryFailureAction { get; set; }

        [XmlElement(ElementName = "tInactivityTimerBr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tInactivityTimerBr { get; set; }
    }
}