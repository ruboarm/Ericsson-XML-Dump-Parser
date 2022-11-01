using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "candNeighborRel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class candNeighborRel
    {
        [XmlElement(ElementName = "physicalLayerSubCellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int physicalLayerSubCellId { get; set; }

        [XmlElement(ElementName = "physicalLayerCellIdGroup", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int physicalLayerCellIdGroup { get; set; }

        [XmlElement(ElementName = "cellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int cellId { get; set; }

        [XmlElement(ElementName = "enbId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int enbId { get; set; }

        [XmlElement(ElementName = "mcc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mcc { get; set; }

        [XmlElement(ElementName = "mnc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mnc { get; set; }

        [XmlElement(ElementName = "mncLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mncLength { get; set; }

        [XmlElement(ElementName = "tac", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int tac { get; set; }

        [XmlElement(ElementName = "mobilityStatusReason", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int mobilityStatusReason { get; set; }
    }
}