using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    public class IRPAgentAttributes
    {
        [XmlElement(ElementName = "systemDN", Namespace = "genericNrm.xsd")]
        public string SystemDN { get; set; }
    }
}
