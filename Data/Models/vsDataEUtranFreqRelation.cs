using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataEUtranFreqRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataEUtranFreqRelation
    {
        [XmlElement(ElementName = "lastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lastModification { get; set; }

        [XmlElement(ElementName = "threshXHighQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXHighQ { get; set; }

        [XmlElement(ElementName = "nonPlannedPhysCellIdRange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nonPlannedPhysCellIdRange { get; set; }

        [XmlElement(ElementName = "caTriggeredRedirectionActive", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool caTriggeredRedirectionActive { get; set; }

        [XmlElement(ElementName = "threshXHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXHigh { get; set; }

        [XmlElement(ElementName = "timeOfLastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime timeOfLastModification { get; set; }

        [XmlElement(ElementName = "cellReselectionPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellReselectionPriority { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string userLabel { get; set; }

        [XmlElement(ElementName = "neighCellConfig", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int neighCellConfig { get; set; }

        [XmlElement(ElementName = "nonPlannedPciTargetIdType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nonPlannedPciTargetIdType { get; set; }

        [XmlElement(ElementName = "threshXLowQ", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXLowQ { get; set; }

        [XmlElement(ElementName = "qOffsetFreq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qOffsetFreq { get; set; }

        [XmlElement(ElementName = "presenceAntennaPort1", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool presenceAntennaPort1 { get; set; }

        [XmlElement(ElementName = "allowedPlmnList", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public PlmnIdentity allowedPlmnList { get; set; }

        [XmlElement(ElementName = "allowedMeasBandwidth", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime allowedMeasBandwidth { get; set; }

        [XmlElement(ElementName = "lbBnrPolicy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbBnrPolicy { get; set; }

        [XmlElement(ElementName = "voicePrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int voicePrio { get; set; }

        [XmlElement(ElementName = "connectedModeMobilityPrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int connectedModeMobilityPrio { get; set; }

        [XmlElement(ElementName = "arpPrio", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int arpPrio { get; set; }

        [XmlElement(ElementName = "blackListEntry", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? blackListEntry { get; set; } // Unknown Type

        [XmlElement(ElementName = "pMax", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int pMax { get; set; }

        [XmlElement(ElementName = "lbActivationThreshold", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbActivationThreshold { get; set; }

        [XmlElement(ElementName = "tReselectionEutraSfMedium", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionEutraSfMedium { get; set; }

        [XmlElement(ElementName = "tReselectionEutraSfHigh", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionEutraSfHigh { get; set; }

        [XmlElement(ElementName = "mobilityAction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mobilityAction { get; set; }

        [XmlElement(ElementName = "nonPlannedPhysCellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nonPlannedPhysCellId { get; set; }

        [XmlElement(ElementName = "qQualMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qQualMin { get; set; }

        [XmlElement(ElementName = "anrMeasOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool anrMeasOn { get; set; }

        [XmlElement(ElementName = "interFreqMeasType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int interFreqMeasType { get; set; }

        [XmlElement(ElementName = "nonPlannedPciCIO", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int nonPlannedPciCIO { get; set; }

        [XmlElement(ElementName = "qRxLevMin", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qRxLevMin { get; set; }

        [XmlElement(ElementName = "tReselectionEutra", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionEutra { get; set; }

        [XmlElement(ElementName = "threshXLow", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int threshXLow { get; set; }

        [XmlElement(ElementName = "createdBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int createdBy { get; set; }

        [XmlElement(ElementName = "adjacentFreq", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string adjacentFreq { get; set; }

        [XmlElement(ElementName = "a5Thr1RsrqFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Thr1RsrqFreqOffset { get; set; }

        [XmlElement(ElementName = "a5Thr1RsrpFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Thr1RsrpFreqOffset { get; set; }

        [XmlElement(ElementName = "a5Thr2RsrpFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Thr2RsrpFreqOffset { get; set; }

        [XmlElement(ElementName = "a5Thr2RsrqFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int a5Thr2RsrqFreqOffset { get; set; }

        [XmlElement(ElementName = "candNeighborRel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<candNeighborRel> candNeighborRels { get; set; }

        [XmlElement(ElementName = "atoAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool atoAllowed { get; set; }

        // 2020-03-10 20:38:35
        [XmlElement(ElementName = "timeOfCreation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime timeOfCreation { get; set; }

        [XmlElement(ElementName = "eutranFreqToQciProfileRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? eutranFreqToQciProfileRelation { get; set; } // Unknown Type

        [XmlElement(ElementName = "blackListEntryIdleMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? blackListEntryIdleMode { get; set; }

        [XmlElement(ElementName = "cellSleepCovCellMeasOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool cellSleepCovCellMeasOn { get; set; }

        [XmlElement(ElementName = "hybridCsgPhysCellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hybridCsgPhysCellId { get; set; }

        [XmlElement(ElementName = "hybridCsgPhysCellIdRange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hybridCsgPhysCellIdRange { get; set; }

        [XmlElement(ElementName = "amoAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool amoAllowed { get; set; }

        [XmlElement(ElementName = "csgPhysCellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csgPhysCellId { get; set; }

        [XmlElement(ElementName = "interFreqMeasTypeUlSinr", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int interFreqMeasTypeUlSinr { get; set; }

        [XmlElement(ElementName = "csgPhysCellIdRange", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csgPhysCellIdRange { get; set; }

        [XmlElement(ElementName = "csgCellTargetIdType", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csgCellTargetIdType { get; set; }

        [XmlElement(ElementName = "lbA5Thr1RsrpFreqOffset", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lbA5Thr1RsrpFreqOffset { get; set; }

        [XmlElement(ElementName = "caFreqProportion", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int caFreqProportion { get; set; }

        [XmlElement(ElementName = "qQualMinRsrqCe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qQualMinRsrqCe { get; set; }

        [XmlElement(ElementName = "tReselectionEutraCe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tReselectionEutraCe { get; set; }

        [XmlElement(ElementName = "qRxLevMinCe", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qRxLevMinCe { get; set; }

        [XmlElement(ElementName = "caFreqPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int caFreqPriority { get; set; }

        [XmlElement(ElementName = "csmUeCapMonitorTime", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int csmUeCapMonitorTime { get; set; }

        [XmlElement(ElementName = "csmUeCapMonitorEnabled", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool csmUeCapMonitorEnabled { get; set; }

        [XmlElement(ElementName = "mdtMeasOn", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool mdtMeasOn { get; set; }
    }
}