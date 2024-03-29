﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "ManagementNode", Namespace = "genericNrm.xsd")]
    public class ManagementNode
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "attributes", Namespace = "genericNrm.xsd")]
        public ManagementNodeAttributes Attributes { get; set; }
    }
}
