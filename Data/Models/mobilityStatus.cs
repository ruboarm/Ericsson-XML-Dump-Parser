using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "mobilityStatus", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class mobilityStatus
    {
        [XmlElement(ElementName = "mobilityStatus", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool available { get; set; }
    }
}
