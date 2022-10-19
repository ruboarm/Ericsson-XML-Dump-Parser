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
    }
}
