using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigEUtraBestCellAnr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigEUtraBestCellAnr
    {
        [XmlElement(ElementName = "hysteresisA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA3 { get; set; }

        [XmlElement(ElementName = "timeToTriggerA3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int timeToTriggerA3 { get; set; }

        [XmlElement(ElementName = "a3offsetAnrDelta", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a3offsetAnrDelta { get; set; }
    }
}