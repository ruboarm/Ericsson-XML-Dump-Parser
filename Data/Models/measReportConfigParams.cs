using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "measReportConfigParams", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class measReportConfigParams
    {
        [XmlElement(ElementName = "a1ThresholdRsrpPrimOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrpPrimOffset { get; set; }

        [XmlElement(ElementName = "a1ThresholdRsrpSecOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrpSecOffset { get; set; }

        [XmlElement(ElementName = "a1ThresholdRsrqPrimOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrqPrimOffset { get; set; }

        [XmlElement(ElementName = "a1ThresholdRsrqSecOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a1ThresholdRsrqSecOffset { get; set; }

        [XmlElement(ElementName = "a2ThresholdRsrpPrimOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrpPrimOffset { get; set; }

        [XmlElement(ElementName = "a2ThresholdRsrpSecOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrpSecOffset { get; set; }

        [XmlElement(ElementName = "a2ThresholdRsrqPrimOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrqPrimOffset { get; set; }

        [XmlElement(ElementName = "a2ThresholdRsrqSecOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a2ThresholdRsrqSecOffset { get; set; }

        [XmlElement(ElementName = "a5Threshold1RsrpOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold1RsrpOffset { get; set; }

        [XmlElement(ElementName = "a5Threshold1RsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold1RsrqOffset { get; set; }

        [XmlElement(ElementName = "a5Threshold2RsrpOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2RsrpOffset { get; set; }

        [XmlElement(ElementName = "a5Threshold2RsrqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Threshold2RsrqOffset { get; set; }

        [XmlElement(ElementName = "b2Threshold1RsrpCdma2000Offset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1RsrpCdma2000Offset { get; set; }

        [XmlElement(ElementName = "b2Threshold1RsrqCdma2000Offset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1RsrqCdma2000Offset { get; set; }

        [XmlElement(ElementName = "b2Threshold2Cdma2000Offset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2Cdma2000Offset { get; set; }

        [XmlElement(ElementName = "b2Threshold1RsrpGeranOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1RsrpGeranOffset { get; set; }

        [XmlElement(ElementName = "b2Threshold1RsrqGeranOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1RsrqGeranOffset { get; set; }

        [XmlElement(ElementName = "b2Threshold2GeranOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2GeranOffset { get; set; }

        [XmlElement(ElementName = "b2Threshold1RsrpUtraOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1RsrpUtraOffset { get; set; }

        [XmlElement(ElementName = "b2Threshold1RsrqUtraOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold1RsrqUtraOffset { get; set; }

        [XmlElement(ElementName = "b2Threshold2EcNoUtraOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2EcNoUtraOffset { get; set; }

        [XmlElement(ElementName = "b2Threshold2RscpUtraOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Threshold2RscpUtraOffset { get; set; }
    }
}
