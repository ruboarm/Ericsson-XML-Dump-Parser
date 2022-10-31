using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "systemInformationBlock8", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class systemInformationBlock8
    {
        [XmlElement(ElementName = "searchWindowSizeCdma", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int searchWindowSizeCdma { get; set; }

        [XmlElement(ElementName = "tReselectionCdmaHrpd", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionCdmaHrpd { get; set; }

        [XmlElement(ElementName = "tReselectionCdmaHrpdSfMedium", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionCdmaHrpdSfMedium { get; set; }

        [XmlElement(ElementName = "tReselectionCdmaHrpdSfHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionCdmaHrpdSfHigh { get; set; }

        [XmlElement(ElementName = "tReselectionCdma1xRtt", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionCdma1xRtt { get; set; }

        [XmlElement(ElementName = "tReselectionCdma1xRttSfHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionCdma1xRttSfHigh { get; set; }

        [XmlElement(ElementName = "tReselectionCdma1xRttSfMedium", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionCdma1xRttSfMedium { get; set; }
    }
}