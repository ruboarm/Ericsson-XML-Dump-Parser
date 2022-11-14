using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataReportConfigInterRatLb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataReportConfigInterRatLb
    {
        [XmlElement(ElementName = "utranHysteresisB1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int utranHysteresisB1 { get; set; }

        [XmlElement(ElementName = "utranB1ThresholdRscp", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int utranB1ThresholdRscp { get; set; }

        [XmlElement(ElementName = "utranB1ThresholdEcNo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int utranB1ThresholdEcNo { get; set; }
    }
}