using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigEUtraBestCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigEUtraBestCell
    {
        [XmlElement(ElementName = "hysteresisA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA3 { get; set; }

        [XmlElement(ElementName = "a3offset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a3offset { get; set; }

        [XmlElement(ElementName = "timeToTriggerA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA3 { get; set; }

        [XmlElement(ElementName = "triggerQuantityA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int triggerQuantityA3 { get; set; }
    }
}