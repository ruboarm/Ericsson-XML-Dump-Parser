using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataLogicalChannelGroup", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataLogicalChannelGroup
    {
        [XmlElement(ElementName = "reservedBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<string>? reservedBy { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? userLabel { get; set; }
    }
}