using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataMeContext", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataMeContext
    {
        [XmlElement(ElementName = "notificationsSupported", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool? NotificationsSupported { get; set; }

        [XmlElement(ElementName = "upgradeMethodCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? UpgradeMethodCapability { get; set; }

        [XmlElement(ElementName = "createUpgradePackageCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? CreateUpgradePackageCapability { get; set; }

        [XmlElement(ElementName = "lastProcessedEventTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime? LastProcessedEventTime { get; set; }

        [XmlElement(ElementName = "associatedRnc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? AssociatedRnc { get; set; }

        [XmlElement(ElementName = "rbsGroupRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? RbsGroupRef { get; set; }


        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? UserLabel { get; set; }

        [XmlElement(ElementName = "ipAddress", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? IpAddress { get; set; }

        [XmlElement(ElementName = "neMIMversion", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? NeMIMversion { get; set; }

        [XmlElement(ElementName = "lostSynchronisation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? LostSynchronisation { get; set; }

        [XmlElement(ElementName = "neType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? NeType { get; set; }

        [XmlElement(ElementName = "bcrLastChange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public long? BcrLastChange { get; set; }

        [XmlElement(ElementName = "bctLastChange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public long? BctLastChange { get; set; }

        [XmlElement(ElementName = "neLinkRelations", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? NeLinkRelations { get; set; }

        [XmlElement(ElementName = "mirrorMIBversion", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? MirrorMIBversion { get; set; }
    }
}