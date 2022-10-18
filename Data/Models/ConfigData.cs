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

        [XmlElement(ElementName = "SubNetwork")]
        public SubNetwork SubNetwork { get; set; }
    }
}
