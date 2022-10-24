using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataLicensing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataLicensing
    {
        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "lastLicensingPiChange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string LastLicensingPiChange { get; set; }

        [XmlElement(ElementName = "emergencyStateInfo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public emergencyStateInfo emergencyStateInfo { get; set; }

        [XmlElement(ElementName = "fingerprint", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string Fingerprint { get; set; }
    }
}