using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalEUtranCellFDD", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalEUtranCellFDD
    {
        [XmlElement(ElementName = "localCellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LocalCellId { get; set; }

        [XmlElement(ElementName = "physicalLayerCellIdGroup", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int PhysicalLayerCellIdGroup { get; set; }

        [XmlElement(ElementName = "physicalLayerSubCellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int PhysicalLayerSubCellId { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "tac", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Tac { get; set; }

        [XmlElement(ElementName = "activePlmnList")]
        public ActivePlmnList ActivePlmnList { get; set; }

        [XmlElement(ElementName = "pciConflict", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<int> PciConflicts { get; set; }

        [XmlElement(ElementName = "pciConflictCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<PciConflictCell> PciConflictCells { get; set; }

        [XmlElement(ElementName = "pciDetectingCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public List<PciDetectingCell> PciDetectingCells { get; set; }

        [XmlElement(ElementName = "earfcndl", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Earfcndl { get; set; }

        [XmlElement(ElementName = "lbEUtranCellOffloadCapacity", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int LbEUtranCellOffloadCapacity { get; set; }
    }
}
