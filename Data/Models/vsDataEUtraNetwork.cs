using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataEUtraNetwork", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataEUtraNetwork
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string userLabel { get; set; }
    }
}