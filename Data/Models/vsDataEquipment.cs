using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "site", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataEquipment
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }
        
        [XmlElement(ElementName = "lastHwPiChange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string LastHwPiChange { get; set; }
    }
}