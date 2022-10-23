using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataMeContext", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataMeContext
    {
        [XmlElement(ElementName = "notificationsSupported", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool NotificationsSupported { get; set; }

        [XmlElement(ElementName = "upgradeMethodCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int UpgradeMethodCapability { get; set; }

        [XmlElement(ElementName = "createUpgradePackageCapability", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CreateUpgradePackageCapability { get; set; }

        [XmlElement(ElementName = "lastProcessedEventTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime LastProcessedEventTime { get; set; }

        [XmlElement(ElementName = "associatedRnc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? AssociatedRnc { get; set; }

        [XmlElement(ElementName = "rbsGroupRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? RbsGroupRef { get; set; }
    }
}