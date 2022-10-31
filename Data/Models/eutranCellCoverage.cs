using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "eutranCellCoverage", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class eutranCellCoverage
    {
        [XmlElement(ElementName = "posCellRadius", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int posCellRadius { get; set; }

        [XmlElement(ElementName = "posCellOpeningAngle", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int posCellOpeningAngle { get; set; }

        [XmlElement(ElementName = "posCellBearing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int posCellBearing { get; set; }
    }
}