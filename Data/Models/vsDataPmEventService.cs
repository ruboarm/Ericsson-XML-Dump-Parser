using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataPmEventService", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataPmEventService
    {
        [XmlElement(ElementName = "totalEventStorageSize", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int totalEventStorageSize { get; set; }

        [XmlElement(ElementName = "ueTraceFileSize", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ueTraceFileSize { get; set; }

        [XmlElement(ElementName = "cellTraceFileSize", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellTraceFileSize { get; set; }

        [XmlElement(ElementName = "totalCellTraceStorageSize", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int totalCellTraceStorageSize { get; set; }

        [XmlElement(ElementName = "totalUeTraceStorageSize", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int totalUeTraceStorageSize { get; set; }

        [XmlElement(ElementName = "streamPortPmUeTrace", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int streamPortPmUeTrace { get; set; }

        [XmlElement(ElementName = "streamStatusPmUeTrace", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<streamStatusPmUeTrace> streamStatusPmUeTraces { get; set; }

        [XmlElement(ElementName = "streamStatusPmCellTrace", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<streamStatusPmCellTrace> streamStatusPmCellTraces { get; set; }

        [XmlElement(ElementName = "cellTraceHighPrioReserve", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellTraceHighPrioReserve { get; set; }

        [XmlElement(ElementName = "eventsExcludedFromUeTrace", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int eventsExcludedFromUeTrace { get; set; }

        [XmlElement(ElementName = "cellTracePeriodicReport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool cellTracePeriodicReport { get; set; }

        [XmlElement(ElementName = "streamStatusNotification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool streamStatusNotification { get; set; }

        [XmlElement(ElementName = "thpFilterThresholdDl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int thpFilterThresholdDl { get; set; }

        [XmlElement(ElementName = "ueTrExcludeNonRacUeRefEvents", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ueTrExcludeNonRacUeRefEvents { get; set; }
    }
}