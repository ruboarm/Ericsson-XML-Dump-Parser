using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataEUtranCellRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataEUtranCellRelation
    {
        [XmlElement(ElementName = "timeOfCreation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime timeOfCreation { get; set; }

        [XmlElement(ElementName = "lastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lastModification { get; set; }

        [XmlElement(ElementName = "isRemoveAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool isRemoveAllowed { get; set; }

        [XmlElement(ElementName = "lbBnrAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool lbBnrAllowed { get; set; }

        [XmlElement(ElementName = "timeOfLastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? timeOfLastModification { get; set; } // Unknown Type

        [XmlElement(ElementName = "qOffsetCellEUtran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int qOffsetCellEUtran { get; set; }

        [XmlElement(ElementName = "sCellCandidate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sCellCandidate { get; set; }

        [XmlElement(ElementName = "isHoAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool isHoAllowed { get; set; }

        [XmlElement(ElementName = "cellIndividualOffsetEUtran", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellIndividualOffsetEUtran { get; set; }

        [XmlElement(ElementName = "coverageIndicator", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int coverageIndicator { get; set; }

        [XmlElement(ElementName = "incomingLoadBalancing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool incomingLoadBalancing { get; set; }

        [XmlElement(ElementName = "includeInSystemInformation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool includeInSystemInformation { get; set; }

        [XmlElement(ElementName = "lbCovIndicated", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool lbCovIndicated { get; set; }

        [XmlElement(ElementName = "loadBalancing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int loadBalancing { get; set; }

        [XmlElement(ElementName = "createdBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int createdBy { get; set; }

        [XmlElement(ElementName = "adjacentCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string adjacentCell { get; set; }

        [XmlElement(ElementName = "sleepModeCovCellCandidate", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sleepModeCovCellCandidate { get; set; }

        [XmlElement(ElementName = "sleepModeCoverageCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool sleepModeCoverageCell { get; set; }

        [XmlElement(ElementName = "sleepModeCapacityCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool sleepModeCapacityCell { get; set; }

        [XmlElement(ElementName = "hoSuccLevel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int hoSuccLevel { get; set; }

        [XmlElement(ElementName = "mobilityStatus", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public mobilityStatus mobilityStatus { get; set; }

        [XmlElement(ElementName = "crsAssistanceInfoPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int crsAssistanceInfoPriority { get; set; }

        [XmlElement(ElementName = "amoAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool amoAllowed { get; set; }

        [XmlElement(ElementName = "amoState", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int amoState { get; set; }

        [XmlElement(ElementName = "sCellPriority", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int sCellPriority { get; set; }

        [XmlElement(ElementName = "ieNBUlCompCoopCellAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool ieNBUlCompCoopCellAllowed { get; set; }
    }
}