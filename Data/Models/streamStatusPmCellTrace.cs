using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "streamStatusPmCellTrace", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class streamStatusPmCellTrace
    {
        [XmlElement(ElementName = "traceReference", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int traceReference { get; set; }

        [XmlElement(ElementName = "scannerId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int scannerId { get; set; }

        [XmlElement(ElementName = "ipAddress", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ipAddress { get; set; }

        [XmlElement(ElementName = "portNumber", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int portNumber { get; set; }

        [XmlElement(ElementName = "fileStatus", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int fileStatus { get; set; }

        [XmlElement(ElementName = "streamStatus", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int streamStatus { get; set; }
    }
}
