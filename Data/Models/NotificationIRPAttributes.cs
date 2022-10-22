using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class NotificationIRPAttributes
    {
        [XmlElement(ElementName = "irpVersion", Namespace = "genericNrm.xsd")]
        public string IrpVersion { get; set; }
    }
}
