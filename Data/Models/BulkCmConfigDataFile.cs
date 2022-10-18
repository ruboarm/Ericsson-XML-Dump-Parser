using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "bulkCmConfigDataFile", Namespace = "configData.xsd")]
    public class BulkCmConfigDataFile
    {
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "fileHeader")]
        public FileHeader FileHeader { get; set; }

        [XmlElement(ElementName = "configData")]
        public ConfigData configData { get; set; }
    }
}