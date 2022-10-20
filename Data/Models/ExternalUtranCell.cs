using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "ExternalUtranCell", Namespace = "utranNrm.xsd")]
    public class ExternalUtranCell
    {
        [XmlAttribute(AttributeName = "id", Namespace = "utranNrm.xsd")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "attributes", Namespace = "utranNrm.xsd")]
        public ExternalUtranCellAttributes Attributes { get; set; }

        [XmlElement(ElementName = "VsDataContainer", Namespace = "genericNrm.xsd")]
        public VsDataContainer VsDataContainer { get; set; }
    }
}
