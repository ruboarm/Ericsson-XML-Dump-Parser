using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "MeContext", Namespace = "genericNrm.xsd")]
    public class MeContext
    {
        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public MeContextAttributes Attributes { get; set; }

        [XmlElement(ElementName = "VsDataContainer", Namespace = "genericNrm.xsd")]
        public List<VsDataContainer> VsDataContainers { get; set; }

        [XmlElement(ElementName = "ManagedElement", Namespace = "genericNrm.xsd")]
        public ManagedElement ManagedElement { get; set; }
    }
}