using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "ManagedElement", Namespace = "genericNrm.xsd")]
    public class ManagedElement
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public ManagedElementAttributes Attributes { get; set; }

        [XmlElement(ElementName = "VsDataContainer", Namespace = "genericNrm.xsd")]
        public List<VsDataContainer> VsDataContainers { get; set; }

        [XmlElement(ElementName = "NodeBFunction", Namespace = "utranNrm.xsd")]
        public NodeBFunction? NodeBFunction { get; set; }
    }
}