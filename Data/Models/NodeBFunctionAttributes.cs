using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "utranNrm.xsd")]
    public class NodeBFunctionAttributes
    {
        [XmlElement(ElementName = "nodeBFunctionIubLink", Namespace = "utranNrm.xsd")]
        public string? nodeBFunctionIubLink { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "utranNrm.xsd")]
        public string? userLabel { get; set; }

        [XmlElement(ElementName = "nodeSCProfileID", Namespace = "utranNrm.xsd")]
        public string? nodeSCProfileID { get; set; } // Unknown Type
    }
}