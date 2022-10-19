using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "pciConflictCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class PciConflictCell
    {
        [XmlElement(ElementName = "enbId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int EnbId { get; set; }

        [XmlElement(ElementName = "cellId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int CellId { get; set; }

        [XmlElement(ElementName = "mcc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Mcc { get; set; }

        [XmlElement(ElementName = "mnc", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int Mnc { get; set; }

        [XmlElement(ElementName = "mncLength", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int MncLength { get; set; }
    }
}