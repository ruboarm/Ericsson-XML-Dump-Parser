using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "systemInformationBlock6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class systemInformationBlock6
    {
        [XmlElement(ElementName = "tReselectionUtra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionUtra { get; set; }

        [XmlElement(ElementName = "tReselectionUtraSfMedium", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionUtraSfMedium { get; set; }

        [XmlElement(ElementName = "tReselectionUtraSfHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionUtraSfHigh { get; set; }
    }
}