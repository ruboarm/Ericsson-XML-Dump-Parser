using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataSecurity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataSecurity
    {
        [XmlElement(ElementName = "authorizationCacheTimeOut", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int AuthorizationCacheTimeOut { get; set; }

        [XmlElement(ElementName = "certExpirWarnTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CertExpirWarnTime { get; set; }

        [XmlElement(ElementName = "autoUpdateCertEnrollmentServer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string AutoUpdateCertEnrollmentServer { get; set; }

        [XmlElement(ElementName = "crlEarlyUpdateInterval", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CrlEarlyUpdateInterval { get; set; }

        [XmlElement(ElementName = "certRevStatusCheck", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CertRevStatusCheck { get; set; }
    }
}