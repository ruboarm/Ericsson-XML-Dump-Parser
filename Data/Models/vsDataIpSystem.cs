using System.Xml.Serialization;

namespace Data.Models
{
    public class vsDataIpSystem
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }
    }
}
