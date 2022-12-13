using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "configData")]
    public class ConfigData
    {
        [XmlAttribute(AttributeName = "dnPrefix")]
        public string DnPrefix { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "SubNetwork", Namespace = "genericNrm.xsd")]
        public SubNetwork SubNetwork { get; set; }
    }
}
