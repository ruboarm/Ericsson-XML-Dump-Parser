using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataSwAllocation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSwAllocation
    {
        [XmlElement(ElementName = "role", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string Role { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }
    }
}