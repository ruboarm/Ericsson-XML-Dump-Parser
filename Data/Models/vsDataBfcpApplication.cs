using System.Xml.Serialization;

namespace Data.Models
{
        [XmlRoot(ElementName = "vsDataBfcpApplication", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataBfcpApplication
    {
        [XmlElement(ElementName = "ipAccessHostGpbMoRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string IpAccessHostGpbMoRef { get; set; }

        [XmlElement(ElementName = "rpuMoRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string RpuMoRef { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }
    }
}