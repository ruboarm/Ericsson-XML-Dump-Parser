using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalEUtranPlmn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalEUtranPlmn
    {
        [XmlElement(ElementName = "plmnIdentity")]
        public PlmnIdentity PlmnIdentity { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }
    }
}
