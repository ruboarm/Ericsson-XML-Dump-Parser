using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataContainer", Namespace = "genericNrm.xsd")]
    public class VsDataContainer
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "attributes")]
        public Attributes Attributes { get; set; }

        [XmlElement(ElementName = "vsDataContainer", Namespace = "genericNrm.xsd")]
        public VsDataContainer VsDataContainerChild { get; set; } //
    }
}
