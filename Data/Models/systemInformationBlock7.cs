using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "systemInformationBlock7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class systemInformationBlock7
    {
        [XmlElement(ElementName = "tReselectionGeran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionGeran { get; set; }

        [XmlElement(ElementName = "tReselectionGeranSfMedium", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionGeranSfMedium { get; set; }

        [XmlElement(ElementName = "tReselectionGeranSfHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionGeranSfHigh { get; set; }
    }
}