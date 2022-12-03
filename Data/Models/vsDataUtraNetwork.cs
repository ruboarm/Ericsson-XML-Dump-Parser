using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataUtraNetwork", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataUtraNetwork
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? userLabel { get; set; }
    }
}