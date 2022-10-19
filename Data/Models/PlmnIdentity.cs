using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "plmnIdentity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class PlmnIdentity
    {
        [XmlElement(ElementName = "mcc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Mcc { get; set; }

        [XmlElement(ElementName = "mnc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Mnc { get; set; }

        [XmlElement(ElementName = "mncLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MncLength { get; set; }
    }
}
