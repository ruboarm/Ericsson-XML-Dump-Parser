using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSwManagement
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "lastUpPiChange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string LastUpPiChange { get; set; }
    }
}