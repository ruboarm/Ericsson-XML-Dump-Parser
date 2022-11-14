using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigEUtraInterFreqLb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigEUtraInterFreqLb
    {
        [XmlElement(ElementName = "a5Threshold2Rsrq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2Rsrq { get; set; }

        [XmlElement(ElementName = "hysteresisA5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hysteresisA5 { get; set; }

        [XmlElement(ElementName = "a5Threshold2Rsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2Rsrp { get; set; }

        [XmlElement(ElementName = "a5Threshold1Rsrp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold1Rsrp { get; set; }
    }
}