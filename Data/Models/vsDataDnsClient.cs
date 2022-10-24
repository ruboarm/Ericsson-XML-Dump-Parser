using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataDnsClient", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataDnsClient
    {
        [XmlElement(ElementName = "defDomainName", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string DefDomainName { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "dscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Dscp { get; set; }
        
        [XmlElement(ElementName = "dnsServerAddress", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<string> DnsServerAddresses { get; set; }
    }
}
