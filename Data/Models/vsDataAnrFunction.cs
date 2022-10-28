using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataAnrFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataAnrFunction
    {
        [XmlElement(ElementName = "prioHoSuccRate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int PrioHoSuccRate { get; set; }

        [XmlElement(ElementName = "zzzTemporary7", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary7 { get; set; }

        [XmlElement(ElementName = "zzzTemporary2", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary2 { get; set; } // Unknow Type

        [XmlElement(ElementName = "removeNrelTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RemoveNrelTime { get; set; }

        [XmlElement(ElementName = "zzzTemporary1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object ZzzTemporary1 { get; set; } // Unknow Type

        [XmlElement(ElementName = "removeNenbTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RemoveNenbTime { get; set; }

        [XmlElement(ElementName = "zzzTemporary4", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary4 { get; set; }

        [XmlElement(ElementName = "maxTimeEventBasedPciConf", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MaxTimeEventBasedPciConf { get; set; }

        [XmlElement(ElementName = "prioHoRate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int PrioHoRate { get; set; }

        [XmlElement(ElementName = "zzzTemporary3", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary3 { get; set; }

        [XmlElement(ElementName = "prioTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int PrioTime { get; set; }

        [XmlElement(ElementName = "zzzTemporary6", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary6 { get; set; }

        [XmlElement(ElementName = "zzzTemporary5", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary5 { get; set; }

        [XmlElement(ElementName = "maxNoPciReportsEvent", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MaxNoPciReportsEvent { get; set; }

        [XmlElement(ElementName = "removeNcellTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int RemoveNcellTime { get; set; }

        [XmlElement(ElementName = "cellRelHoAttRateThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CellRelHoAttRateThreshold { get; set; }

        [XmlElement(ElementName = "zzzTemporary9", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary9 { get; set; }

        [XmlElement(ElementName = "zzzTemporary8", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary8 { get; set; }

        [XmlElement(ElementName = "zzzTemporary10", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary10 { get; set; }

        [XmlElement(ElementName = "zzzTemporary11", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary11 { get; set; }

        [XmlElement(ElementName = "zzzTemporary12", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ZzzTemporary12 { get; set; }

        [XmlElement(ElementName = "probCellDetectMedHoSuccTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ProbCellDetectMedHoSuccTime { get; set; }

        [XmlElement(ElementName = "probCellDetectLowHoSuccTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ProbCellDetectLowHoSuccTime { get; set; }

        [XmlElement(ElementName = "problematicCellPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ProblematicCellPolicy { get; set; }

        [XmlElement(ElementName = "probCellDetectMedHoSuccThres", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ProbCellDetectMedHoSuccThres { get; set; }

        [XmlElement(ElementName = "probCellDetectLowHoSuccThres", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ProbCellDetectLowHoSuccThres { get; set; }

        [XmlElement(ElementName = "plmnWhiteListEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool PlmnWhiteListEnabled { get; set; }

        [XmlElement(ElementName = "perEcgiMeasPlmnWhiteList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool PerEcgiMeasPlmnWhiteList { get; set; }

        [XmlElement(ElementName = "pciConflictDetectionEcgiMeas", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool PciConflictDetectionEcgiMeas { get; set; }

        [XmlElement(ElementName = "pciConflictMobilityEcgiMeas", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool PciConflictMobilityEcgiMeas { get; set; }
    }
}