using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class SubNetworkAttributes
    {
        [XmlElement(ElementName = "userDefinedNetworkType", Namespace = "genericNrm.xsd")]
        public string UserDefinedNetworkType { get; set; }
        
        [XmlElement(ElementName = "userLabel", Namespace = "genericNrm.xsd")]
        public string UserLabel { get; set; }
    }
}
