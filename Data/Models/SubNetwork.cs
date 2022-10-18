using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "SubNetwork", Namespace = "genericNrm.xsd")]
    public class SubNetwork
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "VsDataContainer")]
        public VsDataContainer VsDataContainer { get; set; }
    }
}
