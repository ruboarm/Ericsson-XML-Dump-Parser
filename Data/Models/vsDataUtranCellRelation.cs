using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataUtranCellRelation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class vsDataUtranCellRelation
    {
        [XmlElement(ElementName = "timeOfCreation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}")]
        public DateTime timeOfCreation { get; set; }

        [XmlElement(ElementName = "lastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int lastModification { get; set; }

        [XmlElement(ElementName = "isRemoveAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool isRemoveAllowed { get; set; }

        [XmlElement(ElementName = "lbBnrAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool lbBnrAllowed { get; set; }

        [XmlElement(ElementName = "coverageIndicator", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int coverageIndicator { get; set; }

        [XmlElement(ElementName = "timeOfLastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public object? timeOfLastModification { get; set; } // Unknown Type

        [XmlElement(ElementName = "lbCovIndicated", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool lbCovIndicated { get; set; }

        [XmlElement(ElementName = "loadBalancing", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int loadBalancing { get; set; }

        [XmlElement(ElementName = "isHoAllowed", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public bool isHoAllowed { get; set; }

        [XmlElement(ElementName = "createdBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int createdBy { get; set; }

        [XmlElement(ElementName = "adjacentCell", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string adjacentCell { get; set; }
    }
}
