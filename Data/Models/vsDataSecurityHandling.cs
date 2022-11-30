using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataSecurityHandling", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSecurityHandling
    {
        [XmlElement(ElementName = "rbIdSupervisionActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool rbIdSupervisionActive { get; set; }

        [XmlElement(ElementName = "integrityProtectAlgoPrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> integrityProtectAlgoPrios { get; set; }

        [XmlElement(ElementName = "cipheringAlgoPrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> cipheringAlgoPrios { get; set; }

        [XmlElement(ElementName = "countWrapSupervisionActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool countWrapSupervisionActive { get; set; }
    }
}