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
    }
}
