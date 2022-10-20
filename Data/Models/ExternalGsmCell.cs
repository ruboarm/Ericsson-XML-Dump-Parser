using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "ExternalGsmCell", Namespace = "geranNrm.xsd")]
    class ExternalGsmCell
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "attributes", Namespace = "geranNrm.xsd")]
        public ExternalGsmCellAttributes Attributes { get; set; }

        [XmlElement(ElementName = "VsDataContainer", Namespace = "genericNrm.xsd")]
        public VsDataContainer VsDataContainer { get; set; }
    }
}
