using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataAnrFunctionEUtran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataAnrFunctionEUtran
    {
        [XmlElement(ElementName = "cellAddRsrqThresholdEutran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellAddRsrqThresholdEutran { get; set; }

        [XmlElement(ElementName = "anrUesThreshInterFDecr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesThreshInterFDecr { get; set; }

        [XmlElement(ElementName = "anrUesThreshInterFIncrHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesThreshInterFIncrHo { get; set; }

        [XmlElement(ElementName = "anrUesThreshInterFMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesThreshInterFMin { get; set; }

        [XmlElement(ElementName = "anrUesEUtraIntraFMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesEUtraIntraFMin { get; set; }

        [XmlElement(ElementName = "anrUesEUtraIntraFMax", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesEUtraIntraFMax { get; set; }

        [XmlElement(ElementName = "anrIntraFreqState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrIntraFreqState { get; set; }

        [XmlElement(ElementName = "anrUesEUtraIntraFDecr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesEUtraIntraFDecr { get; set; }

        [XmlElement(ElementName = "cellAddRsrpThresholdEutran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellAddRsrpThresholdEutran { get; set; }

        [XmlElement(ElementName = "lbCellOffloadCapacityPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbCellOffloadCapacityPolicy { get; set; }

        [XmlElement(ElementName = "hoAllowedEutranPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool hoAllowedEutranPolicy { get; set; }

        [XmlElement(ElementName = "anrInterFreqState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrInterFreqState { get; set; }

        [XmlElement(ElementName = "anrUesEUtraIntraFIncrAnr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesEUtraIntraFIncrAnr { get; set; }

        [XmlElement(ElementName = "anrUesThreshInterFIncrAnr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesThreshInterFIncrAnr { get; set; }

        [XmlElement(ElementName = "anrUesEUtraIntraFIncrHo", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesEUtraIntraFIncrHo { get; set; }

        [XmlElement(ElementName = "anrUesThreshInterFMax", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrUesThreshInterFMax { get; set; }

        [XmlElement(ElementName = "x2SetupPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool x2SetupPolicy { get; set; }

        [XmlElement(ElementName = "anrEutranInterFMeasReportMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrEutranInterFMeasReportMin { get; set; }

        [XmlElement(ElementName = "anrEutranInterFMeasReportIncr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrEutranInterFMeasReportIncr { get; set; }

        [XmlElement(ElementName = "anrEutranInterFMeasReportMax", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrEutranInterFMeasReportMax { get; set; }

        [XmlElement(ElementName = "anrEutranInterFMeasReportDecr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int anrEutranInterFMeasReportDecr { get; set; }
    }
}