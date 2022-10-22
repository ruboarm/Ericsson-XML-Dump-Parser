using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class ManagementNodeAttributes
    {
        [XmlElement(ElementName = "manages", Namespace = "genericNrm.xsd")]
        public List<Manages> Manages { get; set; }

        [XmlElement(ElementName = "userDefinedState", Namespace = "genericNrm.xsd")]
        public string UserDefinedState { get; set; }

        [XmlElement(ElementName = "locationName", Namespace = "genericNrm.xsd")]
        public string LocationName { get; set; }

        [XmlElement(ElementName = "userLabel", Namespace = "genericNrm.xsd")]
        public string UserLabel { get; set; }

        [XmlElement(ElementName = "swVersion", Namespace = "genericNrm.xsd")]
        public string SwVersion { get; set; }

        [XmlElement(ElementName = "vendorName", Namespace = "genericNrm.xsd")]
        public string VendorName { get; set; }
    }
}
