using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataLocationArea", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataLocationArea
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "lac", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Lac { get; set; }

        [XmlElement(ElementName = "t3212", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int T3212 { get; set; }

        [XmlElement(ElementName = "att", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Att { get; set; }
    }
}
