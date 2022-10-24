using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataPcmService", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataPcmService
    {
        [XmlElement(ElementName = "g711PacketLossConcealmentExt", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int G711PacketLossConcealmentExt { get; set; }

        [XmlElement(ElementName = "g711PacketLossConcealmentMb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int G711PacketLossConcealmentMb { get; set; }

        [XmlElement(ElementName = "g711PacketLossConcealmentNb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int G711PacketLossConcealmentNb { get; set; }

        [XmlElement(ElementName = "g711PacketLossConcealmentUnid", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int G711PacketLossConcealmentUnid { get; set; }
    }
}
