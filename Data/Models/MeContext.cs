using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "MeContext", Namespace = "genericNrm.xsd")]
    public class MeContext
    {
        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public MeContextAttributes Attributes { get; set; }
    }
}