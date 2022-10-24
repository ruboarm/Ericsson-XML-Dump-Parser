using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataBfcp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataBfcp
    {
        [XmlElement(ElementName = "tcpPort", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int TcpPort { get; set; }

        [XmlElement(ElementName = "dscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Dscp { get; set; }
    }
}