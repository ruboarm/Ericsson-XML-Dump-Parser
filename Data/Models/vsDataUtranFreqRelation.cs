using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataUtranFreqRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataUtranFreqRelation
    {
        [XmlElement(ElementName = "threshXHighQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXHighQ { get; set; }

        [XmlElement(ElementName = "threshXHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXHigh { get; set; }

        [XmlElement(ElementName = "cellReselectionPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellReselectionPriority { get; set; }

        [XmlElement(ElementName = "csFallbackPrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csFallbackPrio { get; set; }

        [XmlElement(ElementName = "utranFreqToQciProfileRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? utranFreqToQciProfileRelation { get; set; } // Unknown Type

        [XmlElement(ElementName = "pMaxUtra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pMaxUtra { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string userLabel { get; set; }

        [XmlElement(ElementName = "altCsfbTargetPrioEc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int altCsfbTargetPrioEc { get; set; }

        [XmlElement(ElementName = "threshXLowQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXLowQ { get; set; }

        [XmlElement(ElementName = "allowedPlmnList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public allowedPlmnList allowedPlmnList { get; set; }

        [XmlElement(ElementName = "qOffsetFreq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qOffsetFreq { get; set; }

        [XmlElement(ElementName = "mobilityActionCsfb", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mobilityActionCsfb { get; set; }

        [XmlElement(ElementName = "lbBnrPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbBnrPolicy { get; set; }

        [XmlElement(ElementName = "voicePrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int voicePrio { get; set; }

        [XmlElement(ElementName = "connectedModeMobilityPrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int connectedModeMobilityPrio { get; set; }

        [XmlElement(ElementName = "maxNrUtranCellRelations", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int maxNrUtranCellRelations { get; set; }

        [XmlElement(ElementName = "altCsfbTargetPrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int altCsfbTargetPrio { get; set; }

        [XmlElement(ElementName = "mobilityAction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mobilityAction { get; set; }

        [XmlElement(ElementName = "csFallbackPrioEC", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csFallbackPrioEC { get; set; }

        [XmlElement(ElementName = "qQualMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qQualMin { get; set; }

        [XmlElement(ElementName = "anrMeasOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool anrMeasOn { get; set; }

        [XmlElement(ElementName = "qRxLevMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qRxLevMin { get; set; }

        [XmlElement(ElementName = "threshXLow", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXLow { get; set; }

        [XmlElement(ElementName = "adjacentFreq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string adjacentFreq { get; set; }

        [XmlElement(ElementName = "b2Thr1RsrqUtraFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Thr1RsrqUtraFreqOffset { get; set; }

        [XmlElement(ElementName = "b2Thr2RscpUtraFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Thr2RscpUtraFreqOffset { get; set; }

        [XmlElement(ElementName = "b2Thr1RsrpUtraFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Thr1RsrpUtraFreqOffset { get; set; }

        [XmlElement(ElementName = "b2Thr2EcNoUtraFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int b2Thr2EcNoUtraFreqOffset { get; set; }

        [XmlElement(ElementName = "atoAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool atoAllowed { get; set; }
    }
}