using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataMrfpFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataMrfpFunction
    {
        [XmlElement(ElementName = "dscpAudio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DscpAudio { get; set; }

        [XmlElement(ElementName = "dscpMultimedia", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int DscpMultimedia { get; set; }

        [XmlElement(ElementName = "rtcpBearerSupervisionTimerMb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RtcpBearerSupervisionTimerMb { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "licenseCapacityAudioConferencing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseCapacityAudioConferencing { get; set; }

        [XmlElement(ElementName = "licenseCapacityHdVideoConferencing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseCapacityHdVideoConferencing { get; set; }

        [XmlElement(ElementName = "licenseCapacityMrfp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseCapacityMrfp { get; set; }

        [XmlElement(ElementName = "licenseStateHdAudio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseStateHdAudio { get; set; }

        [XmlElement(ElementName = "licenseCapacityVideo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseCapacityVideo { get; set; }

        [XmlElement(ElementName = "licenseCapacityVideoConferencing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseCapacityVideoConferencing { get; set; }

        [XmlElement(ElementName = "featureStateContentSharing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int FeatureStateContentSharing { get; set; }

        [XmlElement(ElementName = "licenseStateContentSharing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseStateContentSharing { get; set; }

        [XmlElement(ElementName = "licenseStateMrfIpv6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseStateMrfIpv6 { get; set; }

        [XmlElement(ElementName = "licenseStateMrfPriorityCall", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseStateMrfPriorityCall { get; set; }

        [XmlElement(ElementName = "licenseStateMrfEvs", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LicenseStateMrfEvs { get; set; }
    }
}
