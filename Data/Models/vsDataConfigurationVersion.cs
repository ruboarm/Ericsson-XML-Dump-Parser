using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataConfigurationVersion", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataConfigurationVersion
    {
        [XmlElement(ElementName = "currentUpgradePackage", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string CurrentUpgradePackage { get; set; }

        [XmlElement(ElementName = "configAdmCountdown", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ConfigAdmCountdown { get; set; }

        [XmlElement(ElementName = "autoCreatedCVIsTurnedOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool AutoCreatedCVIsTurnedOn { get; set; }

        [XmlElement(ElementName = "rollbackInitCounterValue", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RollbackInitCounterValue { get; set; }

        [XmlElement(ElementName = "rollbackInitTimerValue", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RollbackInitTimerValue { get; set; }

        [XmlElement(ElementName = "rollbackOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool RollbackOn { get; set; }

        [XmlElement(ElementName = "timeForAutoCreatedCV", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string TimeForAutoCreatedCV { get; set; }
    }
}
