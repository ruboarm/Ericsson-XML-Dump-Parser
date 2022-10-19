using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataRoutingArea", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataRoutingArea
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "rac", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Rac { get; set; }

        [XmlElement(ElementName = "nmo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Nmo { get; set; }
    }
}
