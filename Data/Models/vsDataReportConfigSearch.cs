using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigSearch
    {
        [XmlElement(ElementName = "timeToTriggerA2Critical", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2Critical { get; set; }

        [XmlElement(ElementName = "hysteresisA1A2SearchRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA1A2SearchRsrq { get; set; }

        [XmlElement(ElementName = "timeToTriggerA1Search", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA1Search { get; set; }

        [XmlElement(ElementName = "hysteresisA1A2SearchRsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA1A2SearchRsrp { get; set; }

        [XmlElement(ElementName = "hysteresisA2CriticalRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA2CriticalRsrq { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2Search", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2Search { get; set; }

        [XmlElement(ElementName = "hysteresisA2CriticalRsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA2CriticalRsrp { get; set; }

        [XmlElement(ElementName = "a2CriticalThresholdRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2CriticalThresholdRsrq { get; set; }

        [XmlElement(ElementName = "a2CriticalThresholdRsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2CriticalThresholdRsrp { get; set; }

        [XmlElement(ElementName = "a1a2SearchThresholdRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1a2SearchThresholdRsrq { get; set; }

        [XmlElement(ElementName = "a1a2SearchThresholdRsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1a2SearchThresholdRsrp { get; set; }

        [XmlElement(ElementName = "qciA1A2ThrOffsets", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qciA1A2ThrOffsets { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2CriticalRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2CriticalRsrq { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2OutSearchRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2OutSearchRsrq { get; set; }

        [XmlElement(ElementName = "hysteresisA2OuterSearchRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA2OuterSearchRsrq { get; set; }

        [XmlElement(ElementName = "hysteresisA2OuterSearchRsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA2OuterSearchRsrp { get; set; }

        [XmlElement(ElementName = "a2CriticalThrQci1RsrpOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2CriticalThrQci1RsrpOffset { get; set; }

        [XmlElement(ElementName = "a2OuterSearchThrRsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2OuterSearchThrRsrqOffset { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2OutSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2OutSearch { get; set; }

        [XmlElement(ElementName = "inhibitA2SearchConfig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int inhibitA2SearchConfig { get; set; }

        [XmlElement(ElementName = "timeToTriggerA1SearchRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA1SearchRsrq { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2SearchRsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2SearchRsrq { get; set; }

        [XmlElement(ElementName = "a2OuterSearchThrRsrpOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2OuterSearchThrRsrpOffset { get; set; }

        [XmlElement(ElementName = "a2CriticalThrQci1RsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2CriticalThrQci1RsrqOffset { get; set; }

        [XmlElement(ElementName = "qciA1A2UlThrOffsets", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qciA1A2UlThrOffsets { get; set; }

        [XmlElement(ElementName = "hysteresisA2UlCritical", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA2UlCritical { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2UlCritical", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2UlCritical { get; set; }

        [XmlElement(ElementName = "a1a2UlSearchThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1a2UlSearchThreshold { get; set; }

        [XmlElement(ElementName = "hysteresisA1A2UlSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA1A2UlSearch { get; set; }

        [XmlElement(ElementName = "timeToTriggerA1UlSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA1UlSearch { get; set; }

        [XmlElement(ElementName = "a2UlCriticalThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2UlCriticalThreshold { get; set; }

        [XmlElement(ElementName = "timeToTriggerA2UlSearch", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA2UlSearch { get; set; }
    }
}