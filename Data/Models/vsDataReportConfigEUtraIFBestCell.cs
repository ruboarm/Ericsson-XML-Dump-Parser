using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigEUtraIFBestCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigEUtraIFBestCell
    {
        [XmlElement(ElementName = "hysteresisA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA3 { get; set; }

        [XmlElement(ElementName = "a3offset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a3offset { get; set; }

        [XmlElement(ElementName = "timeToTriggerA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA3 { get; set; }

        [XmlElement(ElementName = "triggerQuantityA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int triggerQuantityA3 { get; set; }

        [XmlElement(ElementName = "timeToTriggerA3Rsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA3Rsrq { get; set; }

        [XmlElement(ElementName = "hysteresisA3RsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA3RsrqOffset { get; set; }

        [XmlElement(ElementName = "a3RsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a3RsrqOffset { get; set; }
    }
}