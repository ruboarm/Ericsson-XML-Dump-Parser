using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "attributes", Namespace = "genericNrm.xsd")]
    public class AlarmIRPAttributes
    {
        [XmlElement(ElementName = "irpVersion", Namespace = "")]
        public string IrpVersion { get; set; }
    }
}
