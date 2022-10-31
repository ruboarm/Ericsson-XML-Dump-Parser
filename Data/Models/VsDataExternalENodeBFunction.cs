using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "vsDataExternalENodeBFunction", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
    public class VsDataExternalENodeBFunction
    {
        [XmlElement(ElementName = "mfbiSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string MfbiSupport { get; set; }

        [XmlElement(ElementName = "eNodeBPlmnId")]
        public ENodeBPlmnId ENodeBPlmnId { get; set; }

        [XmlElement(ElementName = "eNBId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int ENBId { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string UserLabel { get; set; }



        [XmlElement(ElementName = "timeOfCreation", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime? timeOfCreation { get; set; }

        [XmlElement(ElementName = "lastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? lastModification { get; set; }

        [XmlElement(ElementName = "timeOfLastModification", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public DateTime? timeOfLastModification { get; set; }

        [XmlElement(ElementName = "masterEnbFunctionId", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? masterEnbFunctionId { get; set; } // Unknown Type

        [XmlElement(ElementName = "createdBy", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? createdBy { get; set; }

        [XmlElement(ElementName = "ulTrigHoSupport", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? ulTrigHoSupport { get; set; }

        [XmlElement(ElementName = "eSCellCapacityScaling", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? eSCellCapacityScaling { get; set; }

        [XmlElement(ElementName = "interENodeBCAInteractionMode", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public int? interENodeBCAInteractionMode { get; set; }

        [XmlElement(ElementName = "eranVlanPortRef", Namespace = "EricssonSpecificAttributes.17.28.xsd")]
        public string? eranVlanPortRef { get; set; } // Unknown Type
    }
}
