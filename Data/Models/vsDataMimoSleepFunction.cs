using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataMimoSleepFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataMimoSleepFunction
    {
        [XmlElement(ElementName = "switchDownMonitorDurTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int switchDownMonitorDurTimer { get; set; }

        [XmlElement(ElementName = "sleepEndTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public TimeOnly sleepEndTime { get; set; }

        [XmlElement(ElementName = "sleepStartTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public TimeOnly sleepStartTime { get; set; }

        [XmlElement(ElementName = "switchUpMonitorDurTimer", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int switchUpMonitorDurTimer { get; set; }

        [XmlElement(ElementName = "switchUpPrbThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int switchUpPrbThreshold { get; set; }

        [XmlElement(ElementName = "sleepState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sleepState { get; set; }

        [XmlElement(ElementName = "switchDownRrcConnThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int switchDownRrcConnThreshold { get; set; }

        [XmlElement(ElementName = "switchUpRrcConnThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int switchUpRrcConnThreshold { get; set; }

        [XmlElement(ElementName = "switchDownPrbThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int switchDownPrbThreshold { get; set; }

        [XmlElement(ElementName = "sleepMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sleepMode { get; set; }

        [XmlElement(ElementName = "sleepPowerControl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sleepPowerControl { get; set; }
    }
}