using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataEthernetSwitchModule", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataEthernetSwitchModule
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "macAddress", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string MacAddress { get; set; }

        [XmlElement(ElementName = "backPlanePortState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> BackPlanePortStates { get; set; }

        [XmlElement(ElementName = "linkAggLinkSelection", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LinkAggLinkSelection { get; set; }
    }
}