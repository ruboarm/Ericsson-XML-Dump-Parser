using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "emergencyStateInfo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class emergencyStateInfo
    {
        [XmlElement(ElementName = "state", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int State { get; set; }

        [XmlElement(ElementName = "time", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Time { get; set; }

        [XmlElement(ElementName = "expiryTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? ExpiryTime { get; set; }
    }
}