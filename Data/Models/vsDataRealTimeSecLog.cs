using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "connAttemptTimeOut", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataRealTimeSecLog
    {
        [XmlElement(ElementName = "connAttemptTimeOut", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ConnAttemptTimeOut { get; set; }

        [XmlElement(ElementName = "extServerAppName", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ExtServerAppName { get; set; }

        [XmlElement(ElementName = "extServerListConfig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string ExtServerListConfig { get; set; }

        [XmlElement(ElementName = "extServerLogLevel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ExtServerLogLevel { get; set; }

        [XmlElement(ElementName = "featureState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int FeatureState { get; set; }

        [XmlElement(ElementName = "licenseState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseState { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }
    }
}