using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "AlarmIRP", Namespace = "genericNrm.xsd")]
    public class AlarmIRP
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public AlarmIRPAttributes Attributes { get; set; }
    }
}
