using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "fileHeader")]
    public class FileHeader
    {
        [XmlAttribute(AttributeName = "fileFormatVersion")]
        public string FileFormatVersion { get; set; }

        [XmlAttribute(AttributeName = "vendorName")]
        public string VendorName { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
