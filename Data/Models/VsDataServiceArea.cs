using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataServiceArea", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataServiceArea
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "sac", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Sac { get; set; }
    }
}
