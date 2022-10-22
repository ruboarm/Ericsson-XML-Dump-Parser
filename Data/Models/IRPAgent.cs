using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "IRPAgent", Namespace = "genericNrm.xsd")]
    public class IRPAgent
    {
        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public IRPAgentAttributes Attributes { get; set; }

        [XmlElement(ElementName = "AlarmIRP", Namespace = "")]
        public AlarmIRP AlarmIRP { get; set; }

        [XmlElement(ElementName = "NotificationIRP", Namespace = "")]
        public NotificationIRP NotificationIRP { get; set; }
    }
}
