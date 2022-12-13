using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "NodeBFunction", Namespace = "utranNrm.xsd")]
    public class NodeBFunction
    {
        [XmlElement(ElementName = "attributes", Namespace = "utranNrm.xsd")]
        public NodeBFunctionAttributes Attributes { get; set; }

        [XmlElement(ElementName = "VsDataContainer", Namespace = "genericNrm.xsd")]
        public List<VsDataContainer> VsDataContainers { get; set; }
    }
}