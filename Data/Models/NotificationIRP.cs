using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "NotificationIRP", Namespace = "genericNrm.xsd")]
    public class NotificationIRP
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }
}
